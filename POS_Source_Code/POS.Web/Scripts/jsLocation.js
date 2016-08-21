$(document).ready(function () {
    ///Search for  Store / Location / LocationID -Srikanth
    $('#txtLocationSearch').keyup(function () {
        $('.locData').hide();
        $('#NoRecords').hide();
        var searchText = $('#txtLocationSearch').val().toLocaleLowerCase();
        var txtLength = searchText.length;
        var searchExists = false;
        if (txtLength >= 2) {
            
            $('.locData').each(function () {
                var locText = $(this).html();
                if (locText.toLowerCase().indexOf(searchText) >= 0) {
                    $(this).show();
                    searchExists = true;
                }
            });
            if (!searchExists) {
                $('#NoRecords').show();
            }
        }
        else {
            $('.locData').show();
        }
    });

    ///On selecting location/store get details by id -Srikanth
    $(".MasterStore").click(function () {
        var locID = $(this).attr('data-LocationID');
        $.ajax({
            url: '../Location/GetLocationByID',
            data: { 'locationID': locID },
            type: "post",
            cache: false,
            success: function (data) {
                $('#LocationDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });

    $("#btnNewStore").click(function () {
        var locID = $(this).attr('data-LocationID');
        $.ajax({
            url: '../Location/GetLocationByID',
            data: { 'locationID': null },
            type: "post",
            cache: false,
            success: function (data) {
                $('#LocationDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });
   
});