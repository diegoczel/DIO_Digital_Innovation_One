const p1 = new Promise((resolve, reject) => {
  window.setTimeout(() => {
    resolve(console.log("resolvida!"));
  }, 1000);
});

// aguarda a execução da promisse
// .then irá executar após a execução
await p1
  .then((result) => result + ' passando pelo then')
  .then((result) => result + ' e agora acabou')
  .catch((err) => console.log(err.message));

// async await
async function resolvePromise() {
  const p1 = new Promise((resolve, reject) => {
    window.setTimeout(() => {
      resolve(console.log("resolvida!"));
    }, 1000);
  });

  const resolved = await p1
  .then((result) => result + ' passando pelo then')
  .then((result) => result + ' e agora acabou')
  .catch((err) => console.log(err.message));

  return resolved;
}
// promise return a promise
resolvePromise();
// need
await resolvePromise();

// FETCH consumindo api
// fetch return a promise
fetch(url, options)
  .then(response => response.json())// need convert p json quando for str
  .then(json => console.log(json))

// get example
fetch(url, {
  method: 'GET',
  cache: 'no-cache'
})
  .then(response => response.json())
  .then(json => console.log(json))

fetch(url, {
  method: 'POST',
  cache: 'no-cache',
  body: JSON.stringify(data)
})
  .then(response => response.json())
  .then(json => console.log(json))