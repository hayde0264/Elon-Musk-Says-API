# Elon-Musk-Says-API


# Making API Requests
## In JS
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
## In Python
```py
# Must pip3 install requests first

import requests

res = requests.get('http://[::]:8080/json/data.json')
print(res.json())
```
## In PHP
```php
<?php

$url = 'http://[::]:8080/json/data.json';
$data = file_get_contents($url);

echo $data;
?>
```
## In Ruby
```rb
require 'uri'
require 'net/http'

uri = URI('http://[::]:8080/json/data.json')
res = Net::HTTP.get_response(uri)
puts res.body if res.is_a?(Net::HTTPSuccess)
```
