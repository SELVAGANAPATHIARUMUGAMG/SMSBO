$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.marks.mark12;
    var createModal = new abp.ModalManager(abp.appPath + 'Marks/Mark12/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Marks/Mark12/EditModal');

    var dataTable = $('#Mark12Table').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Mark12.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Mark12.Delete'),
                                confirmMessage: function (data) {
                                    return l('Mark12DeletionConfirmationMessage', data.record.id);
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
                title: l('Mark12Language'),
                data: "language"
            },
            {
                title: l('Mark12English'),
                data: "english"
            },
            {
                title: l('Mark12Maths'),
                data: "maths"
            },
            {
                title: l('Mark12Physcics'),
                data: "physcics"
            },
            {
                title: l('Mark12Chemistry'),
                data: "chemistry"
            },
            {
                title: l('Mark12ComputerScience'),
                data: "computerScience"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewMark12Button').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
