# Elon-Musk-Says-API

<b> <code>Intensions:</code> </b>

Strength my back-end skills by providing quotes from Elon Musk.

<b> <code>Tech Used:</code> </b>

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Python](https://img.shields.io/badge/python-3670A0?style=for-the-badge&logo=python&logoColor=ffdd54)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)

<b> <code>Quotes Provided By:</code> </b>


# Making API Requests

# $${\color{lightgreen}IMPORTANT}$$
Start server by going to the root directory and from your shell typing <code>python3 -m http.server 8080</code>.

### With curl
```zsh
curl http://[::]:8080/json/data.json
```
### In JS
```js
const url = 'http://[::]:8080/json/data.json'

fetch(url, {
   headers: {
      'Accept': 'application/json'
   }
})
   .then(response => response.text())
   .then(text => console.log(text))
```
### In Python
```py
# Must pip3 install requests first
import requests

res = requests.get('http://[::]:8080/json/data.json')
print(res.json())
```
### In PHP
```php
<?php

$url = 'http://[::]:8080/json/data.json';
$data = file_get_contents($url);

echo $data;
?>
```
### In Ruby
```rb
require 'uri'
require 'net/http'

uri = URI('http://[::]:8080/json/data.json')
res = Net::HTTP.get_response(uri)
puts res.body if res.is_a?(Net::HTTPSuccess)
```

### Thank you for taking the time to look at my project, 

### Hayden H. 
