$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.teachers.teacher;
    var createModal = new abp.ModalManager(abp.appPath + 'Teachers/Teacher/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Teachers/Teacher/EditModal');

    var dataTable = $('#TeacherTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Teacher.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Teacher.Delete'),
                                confirmMessage: function (data) {
                                    return l('TeacherDeletionConfirmationMessage', data.record.id);
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
                title: l('Age'),
                data: "age"
            },
            //{
            //    title: l('TeacherDOB'),
            //    data: "dOB",
                
            //},
            {
                title: l('ContextNumber'),
                data: "contextNumber"
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

    $('#NewTeacherButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
