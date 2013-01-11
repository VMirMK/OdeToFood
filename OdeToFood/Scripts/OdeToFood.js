/// <reference path="jquery-1.8.3-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />

$(document).ready(function () {

    //    $(".autocomplete").autocomplete(); class="autocomplete"
    $(":input[data-autocomplete]").each(function () {
        $(this).autocomplete({ source: $(this).attr("data-autocomplete") });
    });

    $(":input[data-datepicker]").datepicker();

    $("#searchForm").submit(function () {
        $.getJSON($(this).attr("action"),   //the url to get JSON from 
                  $(this).serialize(),      //make q=yellow, for example
                  function (data) {             //what to do with the response
                      var result = $("#searchTemplate").tmpl(data);
                      $("#searchResults").empty().append(result);
                  }
        );
        return false;
    });
})