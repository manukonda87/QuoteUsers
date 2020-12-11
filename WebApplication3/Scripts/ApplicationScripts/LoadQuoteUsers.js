
$(function () {
    LoadQuoteUsers();
    loadSearchUsers();
});

const LoadQuoteUsers = () => {
    var quoteId = $("#QuoteId").val();
    $.ajax({
        type: "POST",
        url: 'getQuoteUsers',
        data: { quoteId: quoteId },
        success: function (resopnse) {
            $("#loadUsers").html(resopnse);

            $('.datepicker').datepicker({
                dateFormat: "dd/mm/yy"
            });

        }, error: function () {
            alert("Error while getting users data");
        }
    })
}


const CheckCoverageRange = (control) => {
    let value = control.value;
    if (value < 10 || value > 100) {
        alert("Coavergae should between 10 & 100")
        control.value = 10;
    }
}

const loadSearchUsers = () => {
    var quoteId = $("#QuoteId").val();
    var firstName = $('#txtFirstName').val();
    var lastName = $('#txtLastName').val();
    $.ajax({
        type: "POST",
        url: 'getSearchUsers',
        data: { firstName : firstName, lastName :lastName, quoteId: quoteId },
        success: function (resopnse) {
            
            $("#searchUserList").html(resopnse);

        }, error: function () {
            alert("Error while searching users");
        }
    })
}

const addUsertoQuote = (userId) => {
    var quoteId = $("#QuoteId").val();
    $.ajax({
        type: "POST",
        url: 'addUsertoQuote',
        data: { userId: userId, quoteId: quoteId },
        success: function (data) {
            if (data) {
                loadSearchUsers();
                LoadQuoteUsers();
            }
        }, error: function () {
            alert("Error while getting adding user to quote");
        }
    })
}

const deleteUserFromQuote = (userId) => {
    $("#hiddenUserId").val(userId);
    $('#myModal').modal('show');
}

const deleteUser = () => {
    $('#myModal').modal('hide');
    var userId = $("#hiddenUserId").val();
    var quoteId = $("#QuoteId").val();
    $.ajax({
        type: "POST",
        url: '/deleteUserFromQuote',
        data: { userId: userId, quoteId: quoteId },
        success: function (data) {
            if (data) {
                loadSearchUsers();
                LoadQuoteUsers();
            }
        }, error: function () {
            alert("Error while getting deleting user to quote");
        }
    })
}