require 'uri'
require 'net/http'

uri = URI('http://[::]:8080/json/data.json')
res = Net::HTTP.get_response(uri)
puts res.body if res.is_a?(Net::HTTPSuccess)
