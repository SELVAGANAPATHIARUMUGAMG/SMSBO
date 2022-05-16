$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.students.student;
    var createModal = new abp.ModalManager(abp.appPath + 'Students/Student/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Students/Student/EditModal');

    var dataTable = $('#StudentTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Student.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Student.Delete'),
                                confirmMessage: function (data) {
                                    return l('StudentDeletionConfirmationMessage', data.record.name);
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

    $('#NewStudentButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
