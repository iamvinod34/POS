$(document).ready(function () {
    ///Search for  Store / Location / LocationID -Srikanth
    $('#txtSLocationSearch').keyup(function () {
        $('.locData').hide();
        $('#NoRecords').hide();
        var searchText = $('#txtSLocationSearch').val().toLocaleLowerCase();
        var txtLength = searchText.length;
        var searchExists = false;
        if (txtLength >= 2) {
            $('.SlocData').each(function () {
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
            $('.SlocData').show();
        }
    });
    ///On selecting location/store get details by id -Vinod
    $(".MasterSStore").click(function () {
        var locID = $(this).attr('data-SLocationID');

        $.ajax({
            url: '../Storage/GetStorageById',
            data: { 'locationID': locID },
            type: "post",
            cache: false,
            success: function (data) {
                $('#StorageDetails').html(data);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert("Error in geting data from server. Please try again.");
            }
        });
    });
    $("#btnSNewStore").click(function () {
        var locID = $(this).attr('data-LocationID');
        $.ajax({
            url: '../Storage/GetStorageId',
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