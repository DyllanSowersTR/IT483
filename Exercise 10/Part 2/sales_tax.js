var $ = function (id) {
    return document.getElementById(id); 
};

var calculateSalesTax = function(subtotal, taxRate)
{
    var salesTax = subtotal * (taxRate / 100);
    return salesTax;
}
var processEntries = function()
{
    var subtotal = parseFloat($("subtotal").value);
    if(subtotal < 0 || subtotal > 10000)
    {
        alert("Subtotal must be > 0 and <10000");
    }
    else 
    {
        var taxRate = parseFloat($("tax_rate").value);
    }
    if(taxRate < 0 || taxRate > 12)
    {
        alert("Tax Rate must be > 0 and < 12");
    }
    else 
    {
        var salesTax = subtotal * (taxRate / 100);
    }
    var salesTax = subtotal * (taxRate / 100);
    
    $("sales_tax").value = salesTax;
    
    $("total").value = subtotal + salesTax;
    $("subtotal").focus();
}
var clearEntries = function()
{
    $("subtotal").value = "";
    $("tax_rate").value = "";
    $("sales_tax").value = "";
    $("total").value = "";
    $("subtotal").focus();
}
window.onload = function() 
{
    $("subtotal").focus();
    $("calculate").onclick = processEntries;
    $("clear").onclick = clearEntries;
}


