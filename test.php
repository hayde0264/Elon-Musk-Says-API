<?php

$url = 'http://[::]:8080/json/data.json';
$data = file_get_contents($url);

echo $data;
?>
