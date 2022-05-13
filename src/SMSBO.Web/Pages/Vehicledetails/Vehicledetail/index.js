$(function () {

    var l = abp.localization.getResource('SMSBO');

    var service = sMSBO.vehicledetails.vehicledetail;
    var createModal = new abp.ModalManager(abp.appPath + 'Vehicledetails/Vehicledetail/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Vehicledetails/Vehicledetail/EditModal');

    var dataTable = $('#VehicledetailTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                visible: abp.auth.isGranted('SMSBO.Vehicledetail.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('SMSBO.Vehicledetail.Delete'),
                                confirmMessage: function (data) {
                                    return l('VehicledetailDeletionConfirmationMessage', data.record.number);
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
                title: l('Number'),
                data: "number"
            },
            {
                title: l('RegNumber'),
                data: "rNumber"
            },
            {
                title: l('StartFrom'),
                data: "startFrom"
            },
            {
                title: l('End'),
                data: "end"
            },
            {
                title: l('NoOfSheets'),
                data: "noOfSheets"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewVehicledetailButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
