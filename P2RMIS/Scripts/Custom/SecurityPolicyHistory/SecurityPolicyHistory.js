$(function () {
    var networkRangesFilter = {
        extra: false,
        operators: {
            string: {
                startsWith: "Starts with"
            }
        }
    };

    var statusFilter = {
        extra: false,
        operators: {
            string: {
                eq: "Equal to"
            }
        }
    }

    var dateTimeFilter = {
        extra: true,
        operators: {
            date: {
                gt: "After",
                lt: "Before"
            }
        },
        ui: function datepicker(element) {
            element.kendoDatePicker({
                format: "MM/dd/yyyy hh:mm tt"
            });
        }
    }

    var commonCheckboxTemplate = function (e) {
        return "#if(data.all || data." + e.field + "){#" +
            "<div><label><input  type='checkbox' name='" + e.field + "' value='#= data." + e.field + "#'><span>#= data.all || data." + e.field + " # </span></label></div>" +
            "#}#"
    };
    var modalTitle = '<span class="modalSmallCaption modalWarningCaption">Warning</span>';
    var policyId = $("#PolicyId").kendoDropDownList({
        optionLabel: "Select Policy",
        dataTextField: "Value",
        dataValueField: "Index",
        dataSource: {
            transport: {
                read: {
                    dataType: "json",
                    url: "/Security/GetPolicyLookup",
                    cache: false
                }
            }
        }
    }).data("kendoDropDownList");

    $("#FromDate").kendoDatePicker({ format: "MM/dd/yyyy" });
    $("#ToDate").kendoDatePicker({ format: "MM/dd/yyyy" });
    var SinceDaysData = [
        { text: "Past 30 days", value: "30" },
        { text: "Past 60 days", value: "60" },
        { text: "Past 90 days", value: "90" },
        { text: "Past 180 days", value: "180" },
        { text: "Past 365 days", value: "365" }
    ];
    var SinceDays = $("#SinceDays").kendoDropDownList({
        optionLabel: "All",
        dataTextField: "text",
        dataValueField: "value",
        dataSource: SinceDaysData
    }).data("kendoDropDownList");
    var policyStatus = $("#PolicyStatus").kendoDropDownList({
        optionLabel: "Select Status",
        dataTextField: "Value",
        dataValueField: "Index",
        dataSource: {
            transport: {
                read: {
                    dataType: "json",
                    url: "/Security/GetPolicyStatusLookup",
                    cache: false
                }
            }
        }
    }).data("kendoDropDownList");
    $('#SinceDays').data('kendoDropDownList').enable(true);
    $('#FromDate').data('kendoDatePicker').enable(false);
    $('#ToDate').data('kendoDatePicker').enable(false);
    $("#securityPolicyHistoryGrid").kendoGrid({
        height: 550,
        resizable: true,
        toolbar: ["create"],
        columns: [
            { field: "Id", title: "Id", width: 100, filterable: false },
            { field: "Name", title: "Policy Name", width: 140, filterable: { multi: true, itemTemplate: commonCheckboxTemplate } },
            { field: "Type", title: "Policy Type", width: 140, filterable: { multi: true, itemTemplate: commonCheckboxTemplate } },
            { field: "StartDateTime", title: "Policy Start Date & Time", width: 225, filterable: dateTimeFilter, format: "{0:MM/dd/yyyy h:mm tt ET}" },
            { field: "EndDateTime", title: "Policy End Date & Time", width: 215, filterable: dateTimeFilter, format: "{0:MM/dd/yyyy h:mm tt ET}" },
            { field: "RestrictionStartTime", title: "Access Denial Start Time", width: 225, filterable: { multi: true, itemTemplate: commonCheckboxTemplate } },
            { field: "RestrictionEndTime", title: "Access Denial End Time", width: 225, filterable: { multi: true, itemTemplate: commonCheckboxTemplate } },
            { field: "DaysApplied", title: "Days Applied", width: 150, filterable: false },
            { field: "NetworkRanges", title: "Network Addresses", width: 190, filterable: networkRangesFilter },
            { field: "Status", title: "Policy Status", width: 100, filterable: statusFilter },
            { title: "User Policy Status", width: 100, filterable: false },
            { field: "CreatedBy", title: "Changed By", width: 130, filterable: { multi: true, itemTemplate: commonCheckboxTemplate } },
            { field: "CreatedDateTime", title: "Changed Date & Time", width: 200, filterable: dateTimeFilter, format: "{0:MM/dd/yyyy h:mm tt ET}" },
            {
                command: [
                    {
                        name: "enableDisable",
                        text: "",
                        template: "<a class='custom-button k-grid-enableDisable' style='width: 20px' href='javascript:void(0);'><img src='/Content/img/Enable_Disable_Icon.png' alt='Enable/Disable' title='Enable/Disable'/></a>",
                        click: function (e) {
                            e.preventDefault();
                            e.stopPropagation();
                            $('.modal-footer').remove();
                            $("#securityPolicyWarningAlert").text("");
                            var grid = $("#securityPolicyHistoryGrid").data("kendoGrid");
                            var dataItem = grid.dataItem($(e.target).closest("tr"));
                            var policyId = dataItem.Id;
                            var policyName = dataItem.Name;
                            var currentPolicyStatus = dataItem.Status;

                            if (currentPolicyStatus === "Enabled") {
                                $("#securityPolicyWarning").text("Are you sure you want to disable Security Policy '" + policyName + "'?");
                            }
                            else {
                                $("#securityPolicyWarning").text("Are you sure you want to enable Security Policy '" + policyName + "'?");
                            }

                            p2rims.modalFramework.displayModalNoEvent($("#securityPolicyDialog").html(), p2rims.modalFramework.customModalSizes.small, modalTitle);
                            $(".modal-footer").append(p2rims.modalFramework.defaultModalFooters.confirmFooter);
                            $("a[id='closeModal'], button[id='closeDialogBtn']").click(function () { $('.ui-dialog-titlebar-close').click(); });
                            $("button[id='saveDialogChanges']").click(function () {
                                $('#saveDialogChanges').prop("disabled", true);
                                $.ajax({
                                    cache: false,
                                    type: "POST",
                                    url: '/Security/ActivateOrDeactivatePolicy',
                                    data: { policyId: policyId },
                                    success: function (data) {
                                        if (!data.flag) {
                                            $("#securityPolicyWarningAlert").text("Error updating policy " + policyName + ".").show();
                                        } else {
                                            $("#securityPolicyHistoryGrid").data("kendoGrid").dataSource.read();
                                            $("#successMessage").html("Policy " + policyName + " updated successfully!").show();
                                        }
                                    },
                                    error: function (xhr, ajaxOptions, thrownError) {
                                        $("#securityPolicyWarningAlert").text("Failed to update policy " + policyName + ".").show();
                                        $('.ui-dialog-titlebar-close').click();
                                    },
                                    complete: function (data) {
                                        $('.ui-dialog-titlebar-close').click();
                                    }
                                });
                            });

                        }
                    },
                    {
                        name: "edit",
                        text: "",
                        template: "<a class='k-button k-button-icontext k-grid-edit' style='width: 20px' href='javascript:void(0);'><img src='/Content/img/edit_20px_enabled.png' alt='Edit' title='Edit'/></a>",
                        click: function (e) {
                            e.preventDefault();
                            e.stopPropagation();
                            var grid = $("#securityPolicyHistoryGrid").data("kendoGrid");
                            var dataItem = grid.dataItem($(e.target).closest("tr"));
                            var policyId = dataItem.Id;
                            var title = '<span class="modalSmallCaption modalNotificationCaption">Create/Edit Security Policy</span>';
                            $.get("/Security/AddPolicy?policyId=" + policyId, function (data) {
                                p2rims.modalFramework.displayModalNoEvent(data, p2rims.modalFramework.customModalSizes.large, title);
                                $(".modal-footer").append(p2rims.modalFramework.defaultModalFooters.cancelSaveFooter);
                                $("a[id='closeModal'], button[id='closeDialogBtn']").click(function () { $('.ui-dialog-titlebar-close').click() });
                                $("button[id='saveDialogChanges']").click(function () {
                                    submitPolicy();
                                });
                            });

                        }
                    },
                    {
                        name: "delete",
                        text: "",
                        template: "<a class='k-button k-button-icontext k-grid-delete' style='width: 20px'  href='javascript:void(0);'><img src='/Content/img/Delete_Icon.png' alt='Delete' title='Delete' /></a>",
                        click: function (e) {
                            e.preventDefault();
                            e.stopPropagation();
                            $('.modal-footer').remove();
                            $("#securityPolicyWarningAlert").text("");
                            var grid = $("#securityPolicyHistoryGrid").data("kendoGrid");
                            var dataItem = grid.dataItem($(e.target).closest("tr"));
                            var policyId = dataItem.Id;
                            var policyName = dataItem.Name;
                            $("#securityPolicyWarning").text("Are you sure you want to delete Security Policy '" + policyName + "'?");
                            p2rims.modalFramework.displayModalNoEvent($("#securityPolicyDialog").html(), p2rims.modalFramework.customModalSizes.small, modalTitle);
                            $(".modal-footer").append(p2rims.modalFramework.defaultModalFooters.confirmFooter);
                            $("a[id='closeModal'], button[id='closeDialogBtn']").click(function () { $('.ui-dialog-titlebar-close').click(); });
                            $("button[id='saveDialogChanges']").click(function () {
                                $('#saveDialogChanges').prop("disabled", true);
                                $.ajax({
                                    cache: false,
                                    type: "POST",
                                    url: '/Security/ArchivePolicy',
                                    data: { policyId: policyId },
                                    success: function (data) {
                                        if (!data.flag) {
                                            $("#securityPolicyWarningAlert").text("Error deleting policy " + policyName + ".").show();
                                        } else {
                                            $("#securityPolicyHistoryGrid").data("kendoGrid").dataSource.read();
                                            $("#successMessage").html("Policy " + policyName + " deleted successfully!").show();
                                        }
                                    },
                                    error: function (xhr, ajaxOptions, thrownError) {
                                        $("#securityPolicyWarningAlert").text("Failed to delete policy " + policyName + ".").show();
                                        $('.ui-dialog-titlebar-close').click();
                                    },
                                    complete: function (data) {
                                        $('.ui-dialog-titlebar-close').click();
                                    }
                                });
                            });
                        }
                    }
                ],
                title: "Action", width: 100, filterable: false, hidden: !($("#isSecurityAdmin").val())
            },
            { hidden: true, field: "Id" }
        ],
        filterable: {
            extra: false,
            operators: {
                string: {
                    startswith: "Starts with"
                }
            }
        },
        scrollable: true,
        sortable: true,
        pageable: {
            input: true,
            numeric: false,
            refresh: true,
            responsive: false,
            pageSize: 20,
            pageSizes: true,
        },
        excelExport: function (e) {
            var sheet = e.workbook.sheets[0];
            for (var i = 0; i < sheet.rows.length; i++) {
                var row = sheet.rows[i];
                var rightAlign = "right";
                row.cells[2].textAlign = rightAlign;
                row.cells[3].textAlign = rightAlign;
                row.cells[4].textAlign = rightAlign;
                row.cells[5].textAlign = rightAlign;
                row.cells[10].textAlign = rightAlign;
            }
        },
        dataSource: {
            transport: {
                read: {
                    dataType: "json",
                    url: "/Security/GetFilteredPolicyHistories",
                    cache: false
                }
            },
            pageSize: 20,
            batch: true,
            schema: {
                model: {
                    fields: {
                        CreatedDateTime: { type: "date" },
                        StartDateTime: { type: "date" },
                        EndDateTime: { type: "date" }
                    }
                }
            }
        },
        filterMenuInit: function (e) {
            var autocompleteData;
            var policies = e.sender.dataSource.view();
            if (e.field == "Status") {
                autocompleteData = policies.map(function (p) { return p.Status; });
            } else if (e.field == "NetworkRanges") {
                autocompleteData = policies.map(function (p) { return p.NetworkRanges; });
            }
            e.container.find("input.k-textbox").kendoAutoComplete({ dataSource: autocompleteData });
        },
        dataBound: function (e) {
            $("#dataLoadedTimestampSpan").text("Data loaded at " + kendo.toString(kendo.parseDate(new Date().toISOString()), "hh:mm tt MM/dd/yyyy"));
        }
    });

    // This is where we added the same toolbar thats on the bottom of the grid to the top
    var grid = $("#securityPolicyHistoryGrid").data("kendoGrid");
    var wrapper = $('<div class="k-pager-wrap k-grid-pager pagerTop"/>').insertBefore(grid.element.children(".k-grid-header"));
    wrapper.kendoPager($.extend({}, grid.options.pageable, { dataSource: grid.dataSource }));
    grid.element.height("").find(".pagerTop").css("border-width", "0 0 1px 0");

    $("#btnExport").click(function (e) {
        showFileDownloadWarning(function (param) {
            var grid = $("#securityPolicyHistoryGrid").data("kendoGrid");
            grid.saveAsExcel();
        }, null);
    });
    $(document).ajaxStart(function () {
        // Show image container
        $("#ajxLoader").fadeIn();
    });
    $(document).ajaxComplete(function () {
        // Hide image container
        $("#ajxLoader").fadeOut();
    });

    $('#btnFindSecurityPolicyHistory').on('click', function (e) {  //add a click event listener on the delete button
        e.preventDefault();
        e.stopPropagation();
        $('#securityPolicyHistoryGrid').data('kendoGrid').dataSource.read({
            policyId: parseInt($('#PolicyId').val()),
            noOfDays: $('#FromTo').is(':Checked') ? '' : parseInt($('#SinceDays').val()),
            fromDate: $('#FromTo').is(':Checked') ? $('#FromDate').val() : '',
            toDate: $('#FromTo').is(':Checked') ? $('#ToDate').val() : '',
            policyStatus: parseInt($('#PolicyStatus').val())
        });
    });

    $('#Since').on('change', function (e) {
        if (this.checked) {
            $('#SinceDays').data('kendoDropDownList').enable(true);
            $('#FromDate').data('kendoDatePicker').enable(false);
            $('#ToDate').data('kendoDatePicker').enable(false);
        }
    });
    $('#FromTo').on('change', function (e) {
        if (this.checked) {
            $('#SinceDays').data('kendoDropDownList').enable(false);
            $('#FromDate').data('kendoDatePicker').enable(true);
            $('#ToDate').data('kendoDatePicker').enable(true);
        }
    });
    $('#btnClearSecurityPolicyHistory').on('click', function (e) {  //add a click event listener on the delete button
        e.preventDefault();
        e.stopPropagation();
        $('#PolicyId').data("kendoDropDownList").select(0);
        $('#SinceDays').data("kendoDropDownList").select(0);
        $('#FromDate').val('');
        $('#ToDate').val('');
        $('#PolicyStatus').data("kendoDropDownList").select(0);
        $('#securityPolicyHistoryGrid').data('kendoGrid').dataSource.read({
            policyId: parseInt($('#PolicyId').val()),
            noOfDays: parseInt($('#SinceDays').val()),
            fromDate:$('#FromDate').val(),
            toDate: $('#ToDate').val(),
            policyId: parseInt($('#PolicyStatus').val())
        });
    });
});


