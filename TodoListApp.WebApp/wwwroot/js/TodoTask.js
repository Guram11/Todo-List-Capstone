
 $('#tblData').DataTable({
    ajax: { url: '/todotask/getall' },
    columns: [
        { data: 'title', "width": "12%" },
        { data: 'description', "width": "10%" },
        {
            data: 'isCompleted', "width": "10%", "render": function (data) {
                
                return `<div>
                      ${data === true ? "Completed ✅" : "In Progress 📈"}
                </div>`
            } },
        { data: 'dueDate', "width": "15%"},
        { data: 'todoList.title', "width": "10%" },
        {
            data: 'dueDate', "width": "5%", "render": function (data) {
                const date = new Date(data);
            return `<div>
                      ${Date.now() > date ? "Overdue" : ""}
                </div>`
            } },
        { data: 'id',  "width": "20%", "render": function (data) {
                return `<div class="w-75 btn-group" role="group">
                <a href="/todotask/edit?id=${data}" class="btn btn-primary mx-2">
                <i class="bi bi-pencil-square"></i> Edit
                </a>
                <a href="/todotask/delete/${data}" class="btn btn-danger mx-2')
                <i class="bi bi-trash-fill"></i> Delete
                </a>
                </div>`
            }
        },
        {
            data: 'id', "width": "10%", "render": function (data) {
                return `<div class="w-75 btn-group" role="group">
                 <a href="/todotask/details?id=${data}" class="btn btn-primary mx-2">
                <i class="bi bi-pencil-square"></i> Details
                </a>
                </div>`
            }
        },
    ]
});