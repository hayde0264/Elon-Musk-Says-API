# Must pip3 install requests first

import requests

res = requests.get('http://[::]:8080/json/data.json')
print(res.json())
