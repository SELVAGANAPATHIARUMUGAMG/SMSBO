$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.officeStaffs.officeStaff;
    var createModal = new abp.ModalManager(abp.appPath + 'OfficeStaffs/OfficeStaff/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'OfficeStaffs/OfficeStaff/EditModal');

    var dataTable = $('#OfficeStaffTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('SMSBO.OfficeStaff.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.OfficeStaff.Delete'),
                                confirmMessage: function (data) {
                                    return l('OfficeStaffDeletionConfirmationMessage', data.record.name);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('StaffName'),
                data: "name"
            },
            {
                title: l('Age'),
                data: "age"
            },
            {
                title: l('Designation '),
                data: "position",
                render: function (data) {
                    return l('Enum:Position:' + data);
                }
            },
            {
                title: l('Address'),
                data: "address"
            },
            {
                title: l('Mobile'),
                data: "contextNo"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewOfficeStaffButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
