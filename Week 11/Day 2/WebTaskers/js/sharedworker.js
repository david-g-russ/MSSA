let counter = 0;
// front end tries to connect to web worker
this.addEventListener('connect', e => {
    let port = e.ports[0];
    port.start();
    // when port starts receiving data
    port.addEventListener('message', e => {
        if (e.data.length > 0) {
            let result = e.data[0];
            for (let i = 1; i < e.data.length; i++) {
                result = result + e.data[i];
            }
            port.postMessage(result);
        }
    });
});