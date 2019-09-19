var mysql = require('mysql');
class DBConnection {
    constructor(host, user, password, database, table, time, sql = "#NoData-?", getResult = null) {
        this._host = host;
        this._user = user;
        this._password = password;
        this._database = database;
        this._table = table;
        this._time = time;
        if (sql != "#NoData-?") {
            var con = mysql.createConnection({
                host: this._host,
                user: this._user,
                password: this._password
            });
            con.connect(function () {
                con.query(sql, function (err, result) {
                    getResult(result)
                });
            });
        }
    }
    Insert(columns, values, getResult = null) {
        var sql = "INSERT INTO " + this._table + " (" + this._time + ", " + columns + ")" + " values (CURRENT_TIMESTAMP, " + values + ");";
        var con = mysql.createConnection({
            host: this._host,
            user: this._user,
            password: this._password,
            database: this._database
        });
        con.connect(function () {
            con.query(sql, function (err, result) {
                getResult(result)
            });
        });
    }
    Delete(condition, getResult = null) {
        var sql = "DELETE FROM " + this._table + " WHERE " + condition + ";";
        var con = mysql.createConnection({
            host: this._host,
            user: this._user,
            password: this._password,
            database: this._database
        });
        con.connect(function () {
            con.query(sql, function (err, result) {
                getResult(result)
            });
        });
    }
    Update(columnsValues, condition, getResult = null) {
        var sql = "UPDATE " + this._table + " SET " + this._time + " = CURRENT_TIMESTAMP, " + columnsValues + " WHERE " + condition + ";";
        var con = mysql.createConnection({
            host: this._host,
            user: this._user,
            password: this._password,
            database: this._database
        });
        con.connect(function () {
            con.query(sql, function (err, result) {
                getResult(result)
            });
        });
    }
    Select(columns, condition, orderby, getResult = null) {
        var sql = "SELECT " + columns + " FROM " + this._table + " WHERE " + condition + " ORDER BY " + orderby + ";";
        var con = mysql.createConnection({
            host: this._host,
            user: this._user,
            password: this._password,
            database: this._database
        });
        con.connect(function () {
            con.query(sql, function (err, result) {
                getResult(result);
            });
        });
    }
}


var _DBConnection = new DBConnection("localhost", "root", "", "DB_ElPancito", "Productos_ElPancito", "UltimaModificacionProducto");
_DBConnection.Select("Distinct(CategoriaProducto)", "1=1", "CategoriaProducto", Categories => {
    var CategoryModel = new Array();
    var counter = 1;
    CategoryModel[0] = "Todo";
    Categories.forEach(element => {
        CategoryModel[counter++] = element.CategoriaProducto;
    })

    _DBConnection.Select("*", "1=1", "CodigoProducto", Products => {
        var ProductsKeyModel = new Object();
        var counter = 0;
        CategoryModel.forEach(Category => {
            if (Category == "Todo") {
                var Todo = new Array();
                Products.forEach(Product => {
                    Todo[counter++] = Product.CodigoProducto;
                })
                ProductsKeyModel["Todo"] = Todo;
            } else {
                var CategoryKeys = new Array();
                counter = 0;
                Products.forEach(Product => {
                    if (Product.CategoriaProducto == Category) {
                        CategoryKeys[counter++] = Product.CodigoProducto;
                    }
                })
                ProductsKeyModel[Category] = CategoryKeys;
            }
        })
        var ProductsModel = new Object();
        Products.forEach(Product => {
            var ProductObj = new Object();
            ProductObj["Categoria"] = Product.CategoriaProducto;
            ProductObj["Nombre"] = Product.NombreProducto;
            ProductObj["Precio"] = Product.PrecioProducto;
            ProductsModel[Product.CodigoProducto] = ProductObj;
        })
        exports.getCategoryModel = function () { return CategoryModel; };
        exports.getProductsKeyModel = function () { return ProductsKeyModel; };
        exports.getProductsModel = function () { return ProductsModel; };
    });
})

function getDateTime() {

    var date = new Date();

    var year = date.getFullYear();

    var month = date.getMonth() + 1;
    month = (month < 10 ? "0" : "") + month;

    return year + "_" + month;
}

exports.setOrder = function (Products) {
    tableName = "Ordenes_ElPancito_" + getDateTime();
    createTable = "CREATE TABLE IF NOT EXISTS `DB_ElPancito`.`" + tableName +
        "` (`CodigoOrden` INT(8) NOT NULL ,`TiempoOrden` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP ,`CodigoProducto` INT(8) NOT NULL ,`PrecioProducto` DECIMAL(8,2) NOT NULL ,`CantidadProducto` INT(3) NOT NULL ,PRIMARY KEY (CodigoOrden, CodigoProducto));"
    var _DBConnection = new DBConnection("localhost", "root", "", "DB_ElPancito", tableName, "TiempoOrden", createTable, result => {
        if (result.warningCount) {
            _DBConnection.Select("CantidadProducto", "CodigoOrden=0 AND CodigoProducto=0", "CantidadProducto", OrderNum => {
                Products.forEach(Product => {
                    _DBConnection.Insert("CodigoOrden, CodigoProducto, PrecioProducto, CantidadProducto", (OrderNum[0].CantidadProducto + 1) + ", " + Product.Key + ", " + Product.Price + ", " + Product.Quantity, result => { });
                })
                _DBConnection.Update("CantidadProducto=" + (OrderNum[0].CantidadProducto + 1), "CodigoOrden=0 AND CodigoProducto=0", result => { })
            });
        } else {
            _DBConnection.Insert("CodigoOrden, CodigoProducto, PrecioProducto, CantidadProducto", "0,0,0,1", OrderNum => {
                Products.forEach(Product => {
                    _DBConnection.Insert("CodigoOrden, CodigoProducto, PrecioProducto, CantidadProducto", "1 , " + Product.Key + ", " + Product.Price + ", " + Product.Quantity, result => { });
                })
            });
        }
    });
}