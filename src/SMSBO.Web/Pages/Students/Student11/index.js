$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.students.student11;
    var createModal = new abp.ModalManager(abp.appPath + 'Students/Student11/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Students/Student11/EditModal');

    var dataTable = $('#Student11Table').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Student11.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Student11.Delete'),
                                confirmMessage: function (data) {
                                    return l('Student11DeletionConfirmationMessage', data.record.name);
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
                title: l('Name'),
                data: "name"
            },
            {
                title: l('RegNumber'),
                data: "regNumber"
            },
            {
                title: l('Age'),
                data: "age"
            },
            {
                title: l('Department'),
                data: "department",
                render: function (data) {
                    return l('Enum:Departments:' + data);
                }
            },
            {
                title: l('Address'),
                data: "address"
            },
            {
                title: l('Mobile'),
                data: "mobileNumber"
            },
            {
                title: l('EmailID'),
                data: "emailID"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewStudent11Button').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
