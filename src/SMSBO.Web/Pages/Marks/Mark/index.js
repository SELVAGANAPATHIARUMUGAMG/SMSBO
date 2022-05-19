$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.marks.mark;
    var createModal = new abp.ModalManager(abp.appPath + 'Marks/Mark/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Marks/Mark/EditModal');

    var dataTable = $('#MarkTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Mark.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Mark.Delete'),
                                confirmMessage: function (data) {
                                    return l('MarkDeletionConfirmationMessage', data.record.id);
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
                title: l('ExamType'),
                data: "examType",
                render: function (data) {
                    return l('Enum:ExamType:' + data);
                }
            },
            {
                title: l('Tamil'),
                data: "tamil"
            },
            {
                title: l('English'),
                data: "english"
            },
            {
                title: l('Maths'),
                data: "maths"
            },
            {
                title: l('Science'),
                data: "science"
            },
            {
                title: l('SocialScience'),
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

    $('#NewMarkButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
