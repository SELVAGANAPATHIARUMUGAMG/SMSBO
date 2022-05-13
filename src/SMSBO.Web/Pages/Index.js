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