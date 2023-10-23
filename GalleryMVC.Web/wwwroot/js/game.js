var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tbData').DataTable({
        "ajax": { url: '/admin/game/getall' },
        "columns": [
            { data: 'title', "width": "20%" },
            { data: 'developer', "width": "15%" },
            { data: 'publisher', "width": "15%" },
            { data: 'genre.name', "width": "15%" },
            { data: 'price', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-100 btn-group" role="group">
                    <a href="/admin/game/upsert?id=${data}" class="btn btn-outline-warning btn btn-sm mx-2"><i class="bi bi-pencil-square"></i> Edit</a>
                    <a onclick=Delete('/admin/game/delete/${data}') class="btn btn-outline-danger btn btn-sm mx-2"><i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }

        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message)
                }
            })
        }
    })
}