using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookDll;

namespace FrontEndApp
{
    public partial class Form1 : Form
    {
        BookRepository bookRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlNewSubMenu.Visible = false;
            pnlRemoveSubMenu.Visible = false;
            pnlExitSubMenu.Visible = false;
            txtConfirmation.ReadOnly = true;
            bookRepository = new BookRepository(); // data in list is loaded
            cmbGenre.DataSource = Enum.GetValues(typeof(Genre));
            RefreshData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(txtAuthor) == "" && errorProvider1.GetError(txtTitle) == "" && errorProvider1.GetError(dtePublished) == "")
            {
                Book newbook = new Book();
                newbook.Title = txtTitle.Text;
                newbook.Genre = (Genre)cmbGenre.SelectedIndex;
                newbook.Author = txtAuthor.Text;
                newbook.PublishedDate = dtePublished.Value;
                newbook.ISBN = newbook.GenerateISBN();
                bookRepository.AddBook(newbook);
                RefreshData();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bookRepository.DeleteBook(grdBooks.CurrentRow.Index);
            RefreshData();
        }
        private void RefreshData()
        {
            grdBooks.DataSource = null;
            txtAuthor.Clear();
            txtTitle.Clear();
            dtePublished.Value = DateTime.Now.Date;
            cmbGenre.SelectedIndex = 0;

            if (bookRepository.GetBooks().Count > 0)
            {
                grdBooks.DataSource = bookRepository.GetBooks();
                grdBooks.Visible = true;
            }
            else
            {
                grdBooks.Visible = false;
                btnRemove.Visible = false;
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (txtTitle.Text.Length > 30)
                errorMsg = "Your book title is way too long.";
            else if (txtTitle.Text.Length == 0)
                errorMsg = "You need to enter a title";
            else
                return;
            e.Cancel = true;
            txtTitle.Select(0, txtTitle.Text.Length);
            this.errorProvider1.SetError(txtTitle, errorMsg);
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTitle, "");
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (txtAuthor.Text.Length > 30)
                errorMsg = "No one has a name that long.";
            else if (txtAuthor.Text.Length == 0)
                errorMsg = "You need to enter an author.";
            else
                return;
            e.Cancel = true;
            txtAuthor.Select(0, txtAuthor.Text.Length);
            this.errorProvider1.SetError(txtAuthor, errorMsg);
        }

        private void txtAuthor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtAuthor, "");
        }

        private void dtePublished_Validating(object sender, CancelEventArgs e)
        {
            if (dtePublished.Value > DateTime.Now)
            {
                string errorMsg = "What, do you have a time machine?";
                e.Cancel = true;
                dtePublished.Select();
                this.errorProvider1.SetError(dtePublished, errorMsg);
            }
        }

        private void dtePublished_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(dtePublished, "");
        }

        private void lblNewSubMenu_Click(object sender, EventArgs e)
        {
            if (pnlNewSubMenu.Visible == true)
                pnlNewSubMenu.Visible = false;
            else
            {
                pnlRemoveSubMenu.Visible = false;
                pnlExitSubMenu.Visible = false;
                pnlNewSubMenu.Visible = true;
            }  
        }

        private void lblRemoveSubMenu_Click(object sender, EventArgs e)
        {
            if (pnlRemoveSubMenu.Visible == true)
                pnlRemoveSubMenu.Visible = false;
            else
            {
                pnlNewSubMenu.Visible = false;
                pnlExitSubMenu.Visible = false;
                pnlRemoveSubMenu.Visible = true;
            }
        }

        private void grdBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (grdBooks.CurrentRow.Cells[1].Value != null)
                txtConfirmation.Text = grdBooks.CurrentRow.Cells[1].Value.ToString();
            else
                txtConfirmation.Text = "No book currently selected.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (pnlExitSubMenu.Visible == true)
                pnlExitSubMenu.Visible = false;
            else
            {
                pnlNewSubMenu.Visible = false;
                pnlRemoveSubMenu.Visible = false;
                pnlExitSubMenu.Visible = true;
            }
        }
    }
}