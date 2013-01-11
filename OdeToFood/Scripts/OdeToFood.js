/// <reference path="jquery-1.8.3-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />

$(document).ready(function () {

    //    $(".autocomplete").autocomplete(); class="autocomplete"
    $(":input[data-autocomplete]").each(function () {
        $(this).autocomplete({ source: $(this).attr("data-autocomplete") });
    });
})