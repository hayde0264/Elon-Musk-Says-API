const url = 'http://[::]:8080/json/data.json'

fetch(url, {
   headers: {
      'Accept': 'application/json'
   }
})
   .then(response => response.text())
   .then(text => console.log(text))
