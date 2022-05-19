$(function () {

    sMSBO.teachers.teacher.getList({
         maxResultCount: 10
        }).then(function (result) {
        const value = result.totalCount;
        document.getElementById("TeacherCount").innerHTML = value;
    });
    sMSBO.officeStaffs.officeStaff.getList({
        maxResultCount: 10
        }).then(function (result) {
        const value1 = result.totalCount;
        document.getElementById("OfficeStaffCount").innerHTML = value1;
    });
    sMSBO.vehicledetails.vehicledetail.getList({
        maxResultCount: 10
        }).then(function (result) {
        const value2 = result.totalCount;
        document.getElementById("VehicleCount").innerHTML = value2;
    });
    sMSBO.students.student.getList({
        maxResultCount: 10
    }).then(function (result) {
        const value3 = result.totalCount;
        sMSBO.students.student11.getList({
            maxResultCount: 10
        }).then(function (result) {
            const value4 = result.totalCount;
            sMSBO.students.student12.getList({
                maxResultCount: 10
                }).then(function (result) {
                const value5 = result.totalCount;
                const total = value3 + value4+value5;
                document.getElementById("StudentCount").innerHTML = total;
            });
        });
    });
});
$(document).ready(function () {
    $("#10Mark").click(function () {
        window.location.href = '/Marks/Mark';
    });
});