using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceDll
{
    interface ICRUD
    {
        // Create new entries in DB
        void AddTransaction(Transaction trans);
        void AddRecur(Transaction trans);
        Transaction CopyTransaction(Transaction trans);
        void AddUser(User user);
        void AddLoan(Loan loan);
        void AddCategory(Category cat);

        // Pull list of all entries in DB
        ICollection<Transaction> GetTransactions(int id);
        ICollection<Transaction> GetRecur(Transaction trans);
        ICollection<User> GetUsers(int id);
        ICollection<Loan> GetLoans(int id);
        ICollection<Category> GetCategories();

        // Find specific entry in DB
        Transaction FindTransaction(int id);
        User FindUser(int id);
        User FindUser(string name);
        Loan FindLoan(int id);
        Loan FindLoan(string name);
        Category FindCategory(int id);
        Category FindCategory(string name);

        // Separate past and future transactions in DB into lists
        ICollection<Transaction> PastTransactions(int id);
        ICollection<Transaction> PastTransactions(int id, DateTime date);
        decimal SumPastTransactions(int id, DateTime date);
        ICollection<Transaction> MonthTransactions(int id, DateTime date);
        ICollection<Transaction> FutureTransactions(int id);
        ICollection<Category> MonthCategories(int id, DateTime date);

        // Update specific entry in DB
        void UpdateTransaction(int id, Transaction transChanges);
        void UpdateUser(int id, User userChanges);
        void UpdateLoan(int id, Loan loanChanges);
        void UpdateCategory(int id, Category catChanges);

        // Remove specific entry from DB
        void DeleteTransaction(Transaction trans);
        void DeleteRecur(Transaction trans);
        void DeleteUser(User user);
        void DeleteLoan(Loan loan);
        void DeleteCategory(Category cat);
    }

    public class FinanceDB : ICRUD
    {
        #region Initialization

        FinanceDBEntities entities;

        public FinanceDB() // default constructor
        {
            entities = new FinanceDBEntities();
            foreach (var t in entities.Transactions) // populate readable category name from category table
            {
                foreach (var c in entities.Categories)
                {
                    if(t.categoryID == c.categoryID)
                        t.CategoryName = c.categoryName;
                }
            }
            foreach (var t in entities.Transactions) // populate readable loan name from loan table
            {
                foreach (var l in entities.Loans)
                {
                    if(t.loanID == l.loanID)
                        t.LoanName = l.loanName;
                }
            }

            foreach (var l in entities.Loans) // subtract the value of any transactions towards a loan (that have actually occurred) from the remaining loan balance
            {
                l.RemainingBalance = l.balance; // set initial balance
                foreach (var t in entities.Transactions)
                {
                    if (l.loanID == t.loanID && t.date <= DateTime.Now)
                        l.RemainingBalance += t.value;
                }
            }
        }

        #endregion

        #region Create Operations

        // Create new entry in tables
        public void AddTransaction(Transaction trans)
        {
            foreach (var c in entities.Categories) // use category name from category table to populate readable name from ID
            {
                if(trans.categoryID == c.categoryID)
                    trans.CategoryName = c.categoryName;
            }
            foreach (var l in entities.Loans) // use loan name from loan table to populate readable name from ID
            {
                if(trans.loanID == l.loanID)
                    trans.LoanName = l.loanName;
            }
            entities.Transactions.Add(trans);
            entities.SaveChanges();
        }

        public void AddRecur(Transaction trans)
        {
            foreach (var c in entities.Categories) // use category name from category table to populate readable name from ID
            {
                if (trans.categoryID == c.categoryID)
                    trans.CategoryName = c.categoryName;
            }
            foreach (var l in entities.Loans) // use loan name from loan table to populate readable name from ID
            {
                if (trans.loanID == l.loanID)
                    trans.LoanName = l.loanName;
            }
            int recur = (int)trans.recurIntervalDays;
            switch (recur)
            {
                case 365:
                    for (int i = 1; i <= 2; i++)
                    {
                        Transaction transCopy = new Transaction();
                        transCopy = CopyTransaction(trans);            
                        transCopy.date = trans.date.AddYears(i);
                        entities.Transactions.Add(transCopy);
                    }
                    break;
                case 31:
                    for (int i = 1; i <= 24; i++)
                    {
                        Transaction transCopy = new Transaction();
                        transCopy = CopyTransaction(trans);
                        transCopy.date = trans.date.AddMonths(i);
                        entities.Transactions.Add(transCopy);
                    }
                    break;
                case 14:
                    for (int i = 1; i <= 24; i++)
                    {
                        Transaction transCopy = new Transaction();
                        transCopy = CopyTransaction(trans);
                        transCopy.date = trans.date.AddMonths(i);
                        entities.Transactions.Add(transCopy);
                    }
                    for (int i = 1; i <= 24; i++)
                    {
                        Transaction transCopy = new Transaction();
                        transCopy = CopyTransaction(trans);
                        transCopy.date = trans.date.AddMonths(i).AddDays(14);
                        entities.Transactions.Add(transCopy);
                    }
                    break;
                default:
                    for (int i = recur; i <= 730; i += recur)
                    {
                        Transaction transCopy = CopyTransaction(trans);
                        transCopy.date = trans.date.AddDays(i);
                        entities.Transactions.Add(transCopy);
                    }
                    break;
            }
            entities.SaveChanges();
        }

        public void AddRecur(Transaction trans, int durationMonths)
        {
            foreach (var c in entities.Categories) // use category name from category table to populate readable name from ID
            {
                if (trans.categoryID == c.categoryID)
                    trans.CategoryName = c.categoryName;
            }
            foreach (var l in entities.Loans) // use loan name from loan table to populate readable name from ID
            {
                if (trans.loanID == l.loanID)
                    trans.LoanName = l.loanName;
            }
            for (int i = 1; i <= durationMonths; i++)
            {
                Transaction transCopy = CopyTransaction(trans);
                transCopy.date = trans.date.AddMonths(i);
                AddTransaction(transCopy);
            }
            entities.SaveChanges();
        }

        public Transaction CopyTransaction(Transaction trans)
        {
            Transaction transCopy = new Transaction();
            transCopy.transName = trans.transName;
            transCopy.date = trans.date;
            transCopy.recurIntervalDays = trans.recurIntervalDays;
            transCopy.value = trans.value;
            transCopy.isRecurring = trans.isRecurring;
            transCopy.categoryID = trans.categoryID;
            transCopy.userID = trans.userID;
            transCopy.loanID = trans.loanID;

            return transCopy;
        }

        public void AddUser(User user)
        {
            entities.Users.Add(user);
            entities.SaveChanges();
        }

        public void AddLoan(Loan loan)
        {
            entities.Loans.Add(loan);
            entities.SaveChanges();

            Transaction trans = new Transaction();
            trans.transName = loan.loanName;
            trans.value = -loan.payment;
            trans.date = DateTime.Now;
            trans.isRecurring = true;
            trans.recurIntervalDays = 31;
            trans.categoryID = FindCategory("Loans").categoryID;
            trans.userID = loan.userID;
            trans.loanID = FindLoan(loan.loanName).loanID;

            AddRecur(trans,loan.durationMonths);

            entities.SaveChanges();
        }

        public void AddCategory(Category cat)
        {
            entities.Categories.Add(cat);
            entities.SaveChanges();
        }

        #endregion

        #region Read Operations

        // Return list of entries from tables
        public ICollection<Transaction> GetTransactions(int id)
        {
            return (from t in entities.Transactions
                    where t.userID == id
                    orderby t.date descending
                    select t).ToList();
        }

        public ICollection<Transaction> GetRecur(Transaction trans)
        {
            return (from t in entities.Transactions
                    where t.date > DateTime.Now && t.transName == trans.transName && t.value == trans.value
                    select t).ToList();
        }

        public ICollection<User> GetUsers(int id)
        {
            return (from u in entities.Users
                    where u.userID == id
                    select u).ToList();
        }

        public ICollection<Loan> GetLoans(int id)
        {
            return (from l in entities.Loans
                    where l.userID == id
                    select l).ToList();
        }

        public ICollection<Category> GetCategories()
        {
            return (from c in entities.Categories
                    select c).ToList();
        }

        // Return list of past and future entries, respectively, from transactions table
        public ICollection<Transaction> PastTransactions(int id)
        {
            return (from t in entities.Transactions
                        where t.date <= DateTime.Now && t.userID == id
                        orderby t.date descending
                        select t).ToList();
        }

        public ICollection<Transaction> PastTransactions(int id, DateTime date)
        {
            return (from t in entities.Transactions
                    where t.date <= date && t.userID == id
                    orderby t.date descending
                    select t).ToList();
        }

        public decimal SumPastTransactions(int id, DateTime date)
        {
            decimal sum = 0;
            ICollection<Transaction> transList = PastTransactions(id, date);
            foreach (var trans in transList)
                sum += trans.value;
            return sum;
        }

        public ICollection<Transaction> MonthTransactions(int id, DateTime date)
        {
            return (from t in entities.Transactions
                    where t.date.Year == date.Year && t.date.Month == date.Month && t.userID == id
                    orderby t.date ascending
                    select t).ToList();
        }

        public ICollection<Transaction> FutureTransactions(int id)
        {
            return (from t in entities.Transactions
                        where t.date > DateTime.Now && t.userID == id
                        orderby t.date ascending
                        select t).ToList();
        }

        public ICollection<Category> MonthCategories(int id, DateTime date)
        {
            var mTrans = MonthTransactions(id, date);
            foreach (var cat in entities.Categories)
            {
                cat.MonthValue = 0;
                foreach (var trans in mTrans)
                {
                    if (cat.categoryID == trans.categoryID)
                        cat.MonthValue += trans.value;
                }

            }
            return entities.Categories.ToList();
        }

        // Return specific entry from tables
        public Transaction FindTransaction(int id)
        {
            try
            {
                var Transaction = entities.Transactions.First(n => n.transID == id);
                if (Transaction != null)
                    return Transaction;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public User FindUser(int id)
        {
            return entities.Users.Find(id);
        }

        public User FindUser(string name)
        {
            return entities.Users.FirstOrDefault(n => n.username == name);
        }
        public Loan FindLoan(int id)
        {
            return entities.Loans.Find(id);
        }

        public Loan FindLoan(string name)
        {
            return entities.Loans.FirstOrDefault(n => n.loanName == name);
        }

        public Category FindCategory(int id)
        {
            return entities.Categories.Find(id);
        }

        public Category FindCategory(string name)
        {
            return entities.Categories.FirstOrDefault(n => n.categoryName == name);
        }

        #endregion

        #region Update Operations

        public void UpdateTransaction(int id, Transaction transChanges)
        {
            var transToUpdate = entities.Transactions.Find(id);

            if (transChanges.isRecurring && !transToUpdate.isRecurring)
            {
                AddRecur(transChanges);
            }
            else if (transChanges.isRecurring && transToUpdate.isRecurring)
            {
                var recurList = GetRecur(transToUpdate);
                foreach (var recur in recurList)
                    entities.Transactions.Remove(recur);
                AddRecur(transChanges);
            }
            else if (!transChanges.isRecurring && transToUpdate.isRecurring)
            {
                var recurlist = GetRecur(transToUpdate);
                foreach (var recur in recurlist)
                    entities.Transactions.Remove(recur);
            }

            transToUpdate.transName = transChanges.transName;
            transToUpdate.value = transChanges.value;
            transToUpdate.date = transChanges.date;
            transToUpdate.recurIntervalDays = transChanges.recurIntervalDays;
            transToUpdate.categoryID = transChanges.categoryID;
            transToUpdate.userID = transChanges.userID;
            transToUpdate.loanID = transChanges.loanID;
            transToUpdate.isRecurring = transChanges.isRecurring;

            entities.SaveChanges();
        }

        public void UpdateUser(int id, User userChanges)
        {
            var userToUpdate = entities.Users.Find(id);
            userToUpdate.username = userChanges.username;
            userToUpdate.password = userChanges.password;
            userToUpdate.fName = userChanges.fName;
            userToUpdate.lName = userChanges.lName;
            userToUpdate.securityQuestion = userChanges.securityQuestion;
            userToUpdate.securityAnswer = userChanges.securityAnswer;
            entities.SaveChanges();
        }

        public void UpdateLoan(int id, Loan loanChanges)
        {
            var loanToUpdate = entities.Loans.Find(id);

            Transaction searchTrans = new Transaction();
            searchTrans.transName = loanToUpdate.loanName;
            searchTrans.value = loanToUpdate.payment;
            
            DeleteRecur(searchTrans);

            Transaction newtrans = new Transaction();
            newtrans.transName = loanChanges.loanName;
            newtrans.value = -loanChanges.payment;
            newtrans.date = DateTime.Now;
            newtrans.isRecurring = true;
            newtrans.recurIntervalDays = 31;
            newtrans.categoryID = FindCategory("Loans").categoryID;
            newtrans.userID = loanChanges.userID;
            newtrans.loanID = loanChanges.loanID;

            loanToUpdate.loanName = loanChanges.loanName;
            loanToUpdate.balance = loanChanges.balance;
            loanToUpdate.durationMonths = loanChanges.durationMonths;
            loanToUpdate.fixedAPR = loanChanges.fixedAPR;
            loanToUpdate.payment = loanChanges.payment;

            AddRecur(newtrans, loanChanges.durationMonths);

            entities.SaveChanges();
        }

        public void UpdateCategory(int id, Category catChanges)
        {
            var transCats = (from t in entities.Transactions
                             where t.categoryID == id
                             select t).ToList();
            foreach (var cat in transCats)
                cat.CategoryName = catChanges.categoryName;
            var categoryToUpdate = entities.Categories.Find(id);
            categoryToUpdate.categoryName = catChanges.categoryName;
            entities.SaveChanges();
        }

        #endregion

        #region Delete Operations

        // Remove specific entry from tables
        public void DeleteTransaction(Transaction trans)
        {
            entities.Transactions.Remove(trans);
            entities.SaveChanges();
        }

        public void DeleteRecur(Transaction trans)
        {
            var recurList = GetRecur(trans);
            foreach (var recur in recurList)
                entities.Transactions.Remove(recur);
            if (trans.transID != 0)
                entities.Transactions.Remove(trans);
            entities.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            entities.Users.Remove(user);
            entities.SaveChanges();
        }

        public void DeleteLoan(Loan loan)
        {
            Transaction searchTrans = new Transaction();
            searchTrans.transName = loan.loanName;
            searchTrans.value = loan.payment;

            DeleteRecur(searchTrans);

            entities.Loans.Remove(loan);
            entities.SaveChanges();
        }

        public void DeleteCategory(Category cat)
        {
            var transCats = (from t in entities.Transactions
                             where t.categoryID == cat.categoryID
                             select t).ToList();
            foreach (var trans in transCats)
            {
                trans.categoryID = entities.Categories.First().categoryID;
                trans.CategoryName = entities.Categories.First().categoryName;
            }
            entities.Categories.Remove(cat);
            entities.SaveChanges();
        }

        #endregion
    }
}