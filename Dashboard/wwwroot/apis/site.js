function getEmployees(elem,branchId,companyId,removeFirstOption=true) {
    if ($(elem).length > 0) {
     
        $.ajax({
            url: `/Dashboard/Services/GetEmployees?fk_Branch=${branchId}&fk_Company=${companyId}`,
            method: 'get',
            success: function (data) {
                let options = '';

               
                if (removeFirstOption == true) {
                    $(elem).empty();
                }
               
                else {
                    $(elem).find('option').not(':first').remove();
                }

                for (const [key, value] of Object.entries(data)) {
                    options += `<option value="${key}">${value}</option>`;
                }
                $(elem).append(options);
            }
        });
    }
}

function getBranches(elem, companyId, removeFirstOption = true, employeeElem = null) {
    if ($(elem).length > 0) {
        $.ajax({
            url: `/Dashboard/Services/GetBranches?fk_Company=${companyId}`,
            method: 'get',
            success: function (data) {
                let options = '';
                if (removeFirstOption == true) {
                    $(elem).empty();
                }
                else {
                    $(elem).find('option').not(':first').remove();
                }

                for (const [key, value] of Object.entries(data)) {
                    options += `<option value="${key}">${value}</option>`;
                }
                $(elem).append(options);
                if (employeeElem != null) {
                    var fk_branch = $(elem).find("option:first-child").val() != null ? $(elem).find("option:first-child").val() : 0;
                    getEmployees(employeeElem, fk_branch, companyId, removeFirstOption);
                }
            }
        });
    }
}

function getCardTemplates(elem, fk_Type, emptyOption = false) {
    var serviceUrl = "/Dashboard/Services/GetCardTemplates?fk_Type=" + fk_Type;
    $.ajax({
        type: "Get",
        url: serviceUrl,
        success: function (result) {
          
             $(elem).empty();
          
            let options = '';
            
            if (emptyOption) {
                options += `<option value="0">All</option>`;
            }
            
            if (result.length > 0) {
                for (var i = 0; i < result.length; i++) {
                    options += '<option value="' + result[i].id + '">' + result[i].name + '</option>'
                }
            }
            $(elem).append(options);
        }
    });
}

function getCompany(elem, fk_Account) {
    var serviceUrl = "/Dashboard/Services/GetCompany?fk_Account=" + fk_Account;
    $.ajax({
        type: "Get",
        url: serviceUrl,
        success: function (result) {
            $(elem).val(result);
        }
    });
}

function getAccounts(elem, companyId, removeFirstOption = true, employeeElem = null) {
    if ($(elem).length > 0) {
        $.ajax({
            url: `/Dashboard/Services/GetAccounts?fk_Company=${companyId}`,
            method: 'get',
            success: function (data) {
                let options = '';
                if (removeFirstOption == true) {
                    $(elem).empty();
                }
                else {
                    $(elem).find('option').not(':first').remove();
                }

                for (const [key, value] of Object.entries(data)) {
                    options += `<option value="${key}">${value}</option>`;
                }
                $(elem).append(options);
            }
        });
    }
}

function getBadgeData(prefixElem, displayTextElem,fk_Badge) {
    var serviceUrl = "/Dashboard/Services/GetBadgeData?fk_Badge=" + fk_Badge;
    $.ajax({
        type: "Get",
        url: serviceUrl,
        success: function (result) {
            console.log(result[0]);
            var prefix = '';
            if (result[0].prefix != null) {
                prefix = result[0].prefix;
            }
            $(prefixElem).val(prefix);

            if (result[0].haveDisplayText == true) {
                $(displayTextElem).prop('disabled', false)
            }
            else {
                $(displayTextElem).prop('disabled', true)

            }
           
        }
    });
}