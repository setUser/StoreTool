//-----------------------------------------------------------------------------------------
//GLOBALS
CurrentOrderLocalStorage = new StorageArray(localStorage, "#Current_Order_ElPancito");
MaxCategoryIndex = Math.floor(window.innerWidth / 90);
SelectedProductKey = -1;
CategoryIndex = 0;
Currency = "$";
TotalOrder = 0.0;
ReturnOrder = 0.0;
PaidOrder = "";
PaidMax = 10;
PaidDot = false;
PaidDecimals = 0;
//-----------------------------------------------------------------------------------------
//Resize
function setResize() {
    MaxCategoryIndex = Math.floor(window.innerWidth / 90);
    CategoryModel.forEach(function (Category) {
        $("#" + Category).hide();
    });
    for (var i = 0; i < MaxCategoryIndex; i++) {
        $("#" + CategoryModel[i]).show();
    };
    if ($("#" + CategoryModel[CategoryModel.length - 1]).css("display") == "none") {
        $("#" + CategoryModel[MaxCategoryIndex - 1]).hide();
        $("#ToggleCategory").show();
    } else {
        $("#ToggleCategory").hide();
    }
    if (MaxCategoryIndex > CategoryModel.length) {
        $(".CategoryButton").css("width", 100 / (CategoryModel.length) + "%");
    } else {
        $(".CategoryButton").css("width", 100 / MaxCategoryIndex + "%");
    }
    $(".TotalTitleHeader").css("height", window.innerHeight / 14);
    $(".TotalValueData").css("height", window.innerHeight / 14);
    $(".TotalNumberButton").css("height", window.innerHeight / 8);
    $(".ImageLogo").css("height", window.innerWidth / 2.2);
};
//-----------------------------------------------------------------------------------------
//LOAD
addEventListener("load", function () {
    //-----------------------------------------------------------------------------------------
    //QUANTITIES
    function refreshQuantities() {
        TotalOrder = 0.0;
        ProductsKeyModel["Todo"].forEach(function (ProductKey) {
            $("#ProductQuantityData" + ProductKey).text("-");
            $("#ListQuantityData" + ProductKey).text("-");
            $(".ProductQuantityData").removeClass("BuyingQuantity");
        })
        for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
            ProductKey = JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"];
            ProductQuantity = JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductQuantity"];
            $("#ProductQuantityData" + ProductKey).text(ProductQuantity);
            $("#ProductQuantityData" + ProductKey).addClass("BuyingQuantity");
            $("#ListQuantityData" + ProductKey).addClass("BuyingQuantity");
            $("#ListQuantityData" + ProductKey).text(ProductQuantity);
            ProductPrice = ProductsModel[ProductKey]["Precio"];
            ProductPrice = Math.floor(ProductPrice * 100);
            TotalOrder += ProductPrice * ProductQuantity;
        }
        $("#ShowTotal").text(Currency + (TotalOrder / 100));
        ReturnOrder = Math.floor(PaidOrder * 100);
        ReturnOrder = ReturnOrder - TotalOrder;
        if ((ReturnOrder / 100) < 0) {
            $("#TotalReturnData").css("color", "red");
        } else {
            $("#TotalReturnData").css("color", "black");
        }
        $("#TotalReturnData").html(Currency + (ReturnOrder / 100));
    }
    //-----------------------------------------------------------------------------------------
    //UNICODE
    function replaceUnicode(text) {
        text = text.replace("\ufffd", "ñ");
        return text.replace(" ñ", " Ñ");
    };
    //-----------------------------------------------------------------------------------------
    ProductsKeyModel["Todo"].forEach(function (ProductKey) {
        ProductsModel[ProductKey]["Nombre"] = replaceUnicode(ProductsModel[ProductKey]["Nombre"]);
    });
    node = "";
    for (var i = 0; i < 100; i++) {
        node += "<option value='" + i + "'>" + i + "</option>";
    }
    $("#SetQuantity").html(node);
    $("#LessProduct").hide();
    $("#MoreProduct").hide();
    $("#ProductsTable").hide();
    $("#ListTable").hide();
    $("#TotalTable").hide();
    $("#AskSendDiv").hide();
    $("#AskClearDiv").hide();
    $("#SetQuantity").hide();
    $("#TotalPaidData").text(Currency + "0");
    $("#TotalReturnData").text(Currency + "0");
    //-----------------------------------------------------------------------------
    //ShowCategory
    CategoryModel.forEach(function (Category) {
        $("#CategoryRow").append("<td class='CategoryButton' id='" + Category + "'><a href='#" + Category + "' style='text-decoration:none; color: black'>" + Category + "</a></td>");
        $("#" + Category).click({ param0: Category }, ShowProducts);
    });
    //--------------------------------------------------------------------------------------
    //ToggleCategory
    $("#CategoryRow").append("<td class='CategoryButton' id='ToggleCategory'>* * *</td></tr>");
    $("#ToggleCategory").click(ToggleCategory);
    function ToggleCategory() {
        $("#AskSendDiv").hide();
        $("#AskClearDiv").hide();
        $("#LessProduct").hide();
        $("#MoreProduct").hide();
        $("#SetQuantity").hide();
        CategoryModel.forEach(function (Category) {
            $("#" + Category).hide();
        });
        if (CategoryIndex + MaxCategoryIndex - 1 >= CategoryModel.length) {
            CategoryIndex = 0;
        } else {
            CategoryIndex += MaxCategoryIndex - 1;
        }
        for (var i = CategoryIndex; i < CategoryIndex + MaxCategoryIndex - 1; i++) {
            $("#" + CategoryModel[i]).show();
        };
    }
    //-----------------------------------------------------------------------------
    //ShowProducts
    function ShowProducts(event) {
        Category = event.data.param0;
        $("#AskSendDiv").hide();
        $("#AskClearDiv").hide();
        $("#LessProduct").hide();
        $("#MoreProduct").hide();
        $("#SetQuantity").hide();
        $("#ProductsTable").show();
        $("#ListTable").hide();
        $("#TotalTable").hide();
        $("#EmptyDiv").show();
        node = "<tr class='CategoryTitleRow' id='CategoryTitleRow'><th colspan='4' class='CategoryTitleHeader' id='CategoryTitleHeader'><a name='" + Category + "'>" + Category + "</a></th></tr>"
        ProductsKeyModel[Category].forEach(function (ProductKey) {
            node +=
                "<tr class='ProductRow UnSelectedRow' id='ProductRow" + ProductKey + "'>" +
                "<td class='ProductQuantityData' id='ProductQuantityData" + ProductKey + "'>-</td>" +
                //"<td class='ProductKeyData' id='ProductKeyData" + ProductKey + "'>" + ProductKey + "</td>" +
                "<td class='ProductNameData' id='ProductNameData" + ProductKey + "'>" + ProductsModel[ProductKey]["Nombre"] + "</td>" +
                "<td class='ProductPriceData' id='ProductPriceData" + ProductKey + "'>$" + ProductsModel[ProductKey]["Precio"] + "</td>" +
                "</tr>";
        });
        $("#ProductsTable").html(node);
        SelectedProductKey = -1;
        refreshQuantities();
        ProductsKeyModel[Category].forEach(function (ProductKey) {
            $("#ProductRow" + ProductKey).click({ param0: ProductKey }, SelectedRow);

        });
    }
    //--------------------------------------------------------------------------------------
    //ShowList
    $("#ShowList").click(ShowList);
    function ShowList() {
        $("#LessProduct").hide();
        $("#MoreProduct").hide();
        $("#SetQuantity").hide();
        $("#CategoryTable").show();
        $("#ProductsTable").hide();
        $("#ListTable").show();
        $("#TotalTable").hide();
        $("#EmptyDiv").show();
        node = "<tr class='CategoryTitleRow' id='ListTitleRow'><th colspan='4' class='CategoryTitleHeader' id='ListTitleHeader'><a name='List'>Lista</a></th></tr>"
        try {
            for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
                ProductKey = JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"];
                node +=
                    "<tr class='ProductRow UnSelectedRow' id='ListRow" + ProductKey + "'>" +
                    "<td class='ProductQuantityData' id='ListQuantityData" + ProductKey + "'>-</td>" +
                    //"<td class='ProductKeyData' id='ListKeyData" + ProductKey + "'>" + ProductKey + "</td>" +
                    "<td class='ProductNameData' id='ListNameData" + ProductKey + "'>" + ProductsModel[ProductKey]["Nombre"] + "</td>" +
                    "<td class='ProductPriceData' id='ListPriceData" + ProductKey + "'>$" + ProductsModel[ProductKey]["Precio"] + "</td>" +
                    "</tr>";
            }
            if (CurrentOrderLocalStorage.getSize() != 0) {
                node +=
                    "<tr class='ClearListRow' id='ClearListRow'>" +
                    "<td colspan='4' class='ClearList' id='ClearList'>Borrar Lista</td>" +
                    "</tr>";
            }
        }
        catch (e) {
            alert("Un Producto de la Lista Previa fue Alterado de la Base de Datos\nLista Previa Borrada!!!");
            localStorage.clear();
            CurrentOrderLocalStorage.setSize(0);
        }
        $("#ListTable").html(node);
        SelectedProductKey = -1;
        refreshQuantities();
        for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
            ProductKey = JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"];
            $("#ListRow" + ProductKey).click({ param0: ProductKey }, SelectedRow);
        }
        $("#ClearList").click(ClearList);
    }
    //-----------------------------------------------------------------------------
    //ClearList
    function ClearList() {
        $("#LessProduct").hide();
        $("#MoreProduct").hide();
        $("#SetQuantity").hide();
        $("#AskSendDiv").hide(); 
        $("#AskClearDiv").show();
    };
    $("#YesClearDiv").click(YesClear);
    function YesClear() {
        refreshQuantities();
        for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
            ProductKey = JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"];
            $("#ListRow" + ProductKey).html("");
            $("#ListRow" + ProductKey).css("height", "0px");
        }
        localStorage.clear();
        CurrentOrderLocalStorage.setSize(0);
        refreshQuantities();
        $("#ClearList").hide();
        $("#AskClearDiv").hide();
    }
    $("#NoClearDiv").click(NoClear);
    function NoClear() {
        $("#AskClearDiv").hide();
    }
    //-----------------------------------------------------------------------------
    //SelectedRow
    function SelectedRow(event) {
        $("#AskSendDiv").hide();
        $("#AskClearDiv").hide();
        ProductKey = event.data.param0;
        $("#SetQuantity").hide();
        $("#LessProduct").show();
        $("#MoreProduct").show();
        if (ProductKey == SelectedProductKey) {
            MoreProduct();
            $("#SetQuantity").show();
            IsContain = false;
            Index = 0;
            newProductQuantity = 0;
            for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
                if (SelectedProductKey == JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"]) {
                    IsContain = true;
                    Index = i;
                }
            }
            if (IsContain) {
                $("#SetQuantity").val(JSON.parse(CurrentOrderLocalStorage.getItem(Index))["ProductQuantity"]);
            }
            else {
                $("#SetQuantity").val(0);
            }
        }
        else {
            $(".ProductRow").removeClass("SelectedRow");
            $(".ProductRow").addClass("UnSelectedRow");
            $("#ProductRow" + ProductKey).addClass("SelectedRow");
            $("#ListRow" + ProductKey).addClass("SelectedRow");
            SelectedProductKey = ProductKey;
        }
    }
    $("#SetQuantity").change(SetQuantity);
    function SetQuantity() {
        IsContain = false;
        Index = 0;
        newProductQuantity = 0;
        for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
            if (SelectedProductKey == JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"]) {
                IsContain = true;
                Index = i;
            }
        }
        if (IsContain) {
            if ($("#SetQuantity").val() == 0) {
                CurrentOrderLocalStorage.removeItem(Index);
                $("#ListRow" + SelectedProductKey).css("height", "0px");
                $("#ListRow" + SelectedProductKey).html("");
                if (CurrentOrderLocalStorage.getSize() == 0) {
                    ClearList();
                }
            } else {
                CurrentOrderLocalStorage.setItem(Index, JSON.stringify({ ProductKey: SelectedProductKey, ProductQuantity: $("#SetQuantity").val() }));
            }
        } else {
            if ($("#SetQuantity").val() != 0) {
                CurrentOrderLocalStorage.addItem(CurrentOrderLocalStorage.getSize(), JSON.stringify({ ProductKey: SelectedProductKey, ProductQuantity: $("#SetQuantity").val() }));
            }
        }
        $("#SetQuantity").hide();
        refreshQuantities();
    }
    //--------------------------------------------------------------------------------------
    //ShowTotal
    $("#ShowTotal").click(ShowTotal);
    function ShowTotal() {
        $("#AskSendDiv").hide();
        $("#AskClearDiv").hide();
        $("#LessProduct").hide();
        $("#MoreProduct").hide();
        $("#CategoryTable").hide();
        $("#ProductsTable").hide();
        $("#ListTable").hide();
        $("#TotalTable").show();
        $("#EmptyDiv").hide();
        $("#SetQuantity").hide();
        SelectedProductKey = -1;
    }
    //--------------------------------------------------------------------------------------
    for (var i = 0; i < 10; i++) {
        $("#TotalNumberButton" + i).click({ param0: i }, OrderNumberButton);
    }
    function OrderNumberButton(event) {
        if (PaidOrder.length < PaidMax && PaidDecimals < 2) {
            if (PaidOrder == "0") {
                PaidOrder = "";
            }
            PaidOrder = PaidOrder + "" + event.data.param0
            if (PaidDot) {
                PaidDecimals++;
            }
            $("#TotalPaidData").html(Currency + PaidOrder);
            refreshQuantities();
        }
    }
    $("#TotalNumberButtonDot").click(OrderNumberButtonDot);
    function OrderNumberButtonDot() {
        if (PaidOrder.length < PaidMax && !PaidDot) {
            if (PaidOrder == "") {
                PaidOrder = "0.";
            } else {
                PaidOrder = PaidOrder + ".";
            }
            PaidDot = true;
            $("#TotalPaidData").html(Currency + PaidOrder);
            refreshQuantities();
        }
    }
    $("#TotalNumberButtonBackspace").click(OrderNumberButtonBackspace);
    function OrderNumberButtonBackspace() {
        if (PaidDecimals == 0) {
            PaidDot = false;
        }
        if (PaidDot) {
            PaidDecimals--;
        }
        PaidOrder = PaidOrder.substring(0, PaidOrder.length - 1);
        if (PaidOrder == "") {
            $("#TotalPaidData").html(Currency + "0");
        } else {
            $("#TotalPaidData").html(Currency + PaidOrder);
        }
        refreshQuantities();
    }
    //--------------------------------------------------------------------------------------
    //SendList
    $("#SendList").click(SendList);
    function SendList() {
        $("#AskClearDiv").hide();
        ShowList();
        if (CurrentOrderLocalStorage.getSize() != 0) {
            $("#AskSendDiv").show();
        } else {
            $("#ListTable").append("<tr><td style='text-align : center; color :red; height : 40px'>la lista esta vacia</td></tr>")
        }
    }
    $("#YesSendDiv").click(YesSend);
    function YesSend() {
        var CurrentOrderArray = new Array(CurrentOrderLocalStorage.getSize());
        for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
            CurrentOrderArray[i] = CurrentOrderLocalStorage.getItem(i);
        }
        try {
            $.post("Controller/StoreController.php", { RequestType: "UploadOrder", CurrentOrder: JSON.stringify(CurrentOrderArray) },
                function (data, status) {
                    alert("Server: " + data + "\nStatus: " + status);
                });
            ClearList();
            $("#AskSendDiv").hide();
        } catch (e) {
            alert("Fallo al Guardar\n" + e);
        }
    }
    $("#NoSendDiv").click(NoSend);
    function NoSend() {
        $("#AskSendDiv").hide();
    }
    //--------------------------------------------------------------------------------------
    //LessProduct
    $("#LessProduct").click(LessProduct);
    function LessProduct() {
        if (SelectedProductKey != -1) {
            IsContain = false;
            Index = 0;
            newProductQuantity = 0;
            for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
                if (SelectedProductKey == JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"]) {
                    IsContain = true;
                    Index = i;
                }
            }
            if (IsContain) {
                newProductQuantity = JSON.parse(CurrentOrderLocalStorage.getItem(Index))["ProductQuantity"] - 1;
                if (newProductQuantity == 0) {
                    OffProductKey = JSON.parse(CurrentOrderLocalStorage.getItem(Index))["ProductKey"];
                    $("#ListRow" + OffProductKey).css("height", "0px");
                    $("#ListRow" + OffProductKey).html("");
                    CurrentOrderLocalStorage.removeItem(Index);
                } else {
                    CurrentOrderLocalStorage.setItem(Index, JSON.stringify({ ProductKey: SelectedProductKey, ProductQuantity: newProductQuantity }));
                }
            }
        }
        if (CurrentOrderLocalStorage.getSize() == 0) {
            ClearList();
        }
        refreshQuantities();
    }
    //--------------------------------------------------------------------------------------
    //MoreProduct
    $("#MoreProduct").click(MoreProduct);
    function MoreProduct() {
        if (SelectedProductKey != -1) {
            IsContain = false;
            Index = 0;
            newProductQuantity = 0;
            for (var i = 0; i < CurrentOrderLocalStorage.getSize(); i++) {
                if (SelectedProductKey == JSON.parse(CurrentOrderLocalStorage.getItem(i))["ProductKey"]) {
                    IsContain = true;
                    Index = i;
                }
            }
            if (IsContain) {
                oldProductQuantity = parseInt(JSON.parse(CurrentOrderLocalStorage.getItem(Index))["ProductQuantity"]);
                newProductQuantity = oldProductQuantity + 1;
                CurrentOrderLocalStorage.setItem(Index, JSON.stringify({ ProductKey: SelectedProductKey, ProductQuantity: newProductQuantity }));
            } else {
                CurrentOrderLocalStorage.addItem(CurrentOrderLocalStorage.getSize(), JSON.stringify({ ProductKey: SelectedProductKey, ProductQuantity: 1 }));
            }
        }
        refreshQuantities();
    }
    ShowList();
    refreshQuantities()
});