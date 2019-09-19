var http = require('http');
var qs = require("querystring");
var fs = require('fs');
var models = require('../src/DBConnection.js');

var indexhtml;
var indexcss;
var indexjs;
var StorageArray;
var ElPancitoLOGO;
var Icon_ElPancito;

fs.readFile('./View/Store/index.html', function (err, data) {
    indexhtml = data;
});
fs.readFile('./View/Store/index.css', function (err, data) {
    indexcss = data;
});
fs.readFile('./View/Store/index.js', function (err, data) {
    indexjs = data;
});
fs.readFile('./src/StorageArray.js', function (err, data) {
    StorageArray = data;
});
fs.readFile('./Resources/ElPancitoLOGO.png', function (err, data) {
    ElPancitoLOGO = data;
});
fs.readFile('./Resources/Icon_ElPancito.png', function (err, data) {
    Icon_ElPancito = data;
});

function getDateTime() {

    var date = new Date();

    var hour = date.getHours();
    hour = (hour < 10 ? "0" : "") + hour;

    var min = date.getMinutes();
    min = (min < 10 ? "0" : "") + min;

    var sec = date.getSeconds();
    sec = (sec < 10 ? "0" : "") + sec;

    var year = date.getFullYear();

    var month = date.getMonth() + 1;
    month = (month < 10 ? "0" : "") + month;

    var day = date.getDate();
    day = (day < 10 ? "0" : "") + day;

    return year + "-" + month + "-" + day + " " + hour + ":" + min + ":" + sec;
}

http.createServer(function (req, res) {
    if (req.url == "/Controller/StoreController.php") {
        var body = "";
        req.on("data", function (data) {
            body += data;
        });
        req.on("end", function () {
            var obj = qs.parse(body);
            var CurrentOrderJSON = obj.CurrentOrder;
            CurrentOrderArray = JSON.parse(CurrentOrderJSON);
            var Products = models.getProductsModel();
            var Order = new Array();
            var counter = 0;
            CurrentOrderArray.forEach(ProductJSON => {
                Product = JSON.parse(ProductJSON);
                ProductKey = Product.ProductKey;
                ProductPrice = Products[ProductKey].Precio;
                ProductQuantity = Product.ProductQuantity;
                var ProductObj = new Object();
                ProductObj["Key"] = ProductKey;
                ProductObj["Price"] = ProductPrice;
                ProductObj["Quantity"] = ProductQuantity;
                Order[counter++] = ProductObj;
            });
            models.setOrder(Order);
            console.log(Order);
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.write("Orden Guardada el " + getDateTime());
            res.end();
        })
    }
    else if (req.url == "/View/Store/index.css") {
        res.writeHead(200, { 'Content-Type': 'text/css' });
        res.write(indexcss);
        res.end();
    }
    else if (req.url == "/View/Store/index.js") {
        res.writeHead(200, { 'Content-Type': 'text/js' });
        res.write(indexjs);
        res.end();
    }
    else if (req.url == "/src/StorageArray.js") {
        res.writeHead(200, { 'Content-Type': 'text/js' });
        res.write(StorageArray);
        res.end();
    }
    else if (req.url == "/Resources/ElPancitoLOGO.png") {
        res.writeHead(200, { 'Content-Type': 'image/png' });
        res.write(ElPancitoLOGO);
        res.end();
    }
    else if (req.url == "/Resources/Icon_ElPancito.png") {
        res.writeHead(200, { 'Content-Type': 'image/png' });
        res.write(Icon_ElPancito);
        res.end();
    } else {
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write(indexhtml);
        res.write('<script>var CategoryModel = ' + JSON.stringify(models.getCategoryModel()) + ';</script>');
        res.write('<script>var ProductsKeyModel = ' + JSON.stringify(models.getProductsKeyModel()) + ';</script>');
        res.write('<script>var ProductsModel = ' + JSON.stringify(models.getProductsModel()) + ';</script>');
        res.end();
    }
}).listen(8080);