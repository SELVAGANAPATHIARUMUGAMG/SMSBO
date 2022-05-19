$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.marks.mark11;
    var createModal = new abp.ModalManager(abp.appPath + 'Marks/Mark11/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Marks/Mark11/EditModal');

    var dataTable = $('#Mark11Table').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Mark11.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Mark11.Delete'),
                                confirmMessage: function (data) {
                                    return l('Mark11DeletionConfirmationMessage', data.record.id);
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
                title: l('Mark11Tamil'),
                data: "tamil"
            },
            {
                title: l('Mark11English'),
                data: "english"
            },
            {
                title: l('Mark11Maths'),
                data: "maths"
            },
            {
                title: l('Mark11Science'),
                data: "science"
            },
            {
                title: l('Mark11SocialScience'),
                data: "socialScience"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewMark11Button').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
