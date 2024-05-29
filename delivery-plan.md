# To-do List Application

## Development Tasks

Development tasks are tasks with a technical description of what needs to be done. The only development tasks T01-T04 have sub-tasks with details that can help you get started on the project.

* T01: Add and configure C# projects.
    * Create C# projects and add them to the solution file; configure project dependencies as expected.
    * Enable built-in .NET code analysis tools in C# projects; add the StyleCop NuGet package as a dependency to all C# projects.
* T02: Add and configure `TodoListDbContext`.
    * Create a database context for the *TodoListDb* database named `TodoListDbContext` in the *TodoListApp.Services.Database* project.
    * Configure `TodoListDbContext` as a dependency in *TodoListApp.WebApi* app's dependency injection container; the context must be initialized with a connection string added to the application config file.
* T03: Implement Epic 1 [backend](https://en.wikipedia.org/wiki/Frontend_and_backend) functionality in the *TodoList.WebApi* application.
    * Add a new entity class named `TodoListEntity` to the *TodoList.Services.Database* project; configure the entity as a DbSet<T> in the `TodoListDbContext` class.
    * Add a new service interface named `ITodoListService` and a data class named `TodoList` to the *TodoList.Services* project.
    * Add a new service class named `TodoListDatabaseService` to the *TodoList.Services.Database* project to manage to-do lists in the database; configure the service as a dependency in the *TodoList.WebApi* app.
    * Add a new controller class named `TodoListController` to the *TodoList.WebApi* project; resolve service dependencies using constructor injection.
    * US01: Add new methods to the `TodoListDatabaseService` to get the list of to-do lists from the database; make all necessary changes in other classes and methods.
    * US01: Implement the REST endpoint in the *TodoList.WebApi* project to get the list of to-do lists; the list must be in JSON format. Place the model classes for this endpoint in the *TodoListApp.WebApi.Models* project.
    * US02: Add new methods to the `TodoListDatabaseService` to add a new to-do list; make all necessary changes in other classes and methods.
    * US02: Implement the REST endpoint in the *TodoList.WebApi* project to add a new to-do list; the input data must be in JSON format; and the endpoint must return meaningful status codes in case of errors. Place the model classes for this endpoint in the *TodoListApp.WebApi.Models* project.
    * US03: Add new methods to the `TodoListDatabaseService` to delete an existing to-do list; make all necessary changes in other classes and methods.
    * US03: Implement the REST endpoint in the *TodoList.WebApi* project to delete an existing to-do list; the endpoint must return meaningful status codes in case of errors. Place the model classes for this endpoint in the *TodoListApp.WebApi.Models* project.
    * US04: Add new methods to the `TodoListDatabaseService` to update an existing to-do list's data; make all necessary changes in other classes and methods.
    * US04: Implement the REST endpoint in the *TodoList.WebApi* project to update an existing to-do list's data; the endpoint must return meaningful status codes in case of errors. Place the model classes for this endpoint in the *TodoListApp.WebApi.Models* project.
* T04: Implement Epic 1 frontend functionality in the *TodoList.WebApp* application.
    * Add a new service class named `TodoListWebApiService` to the *TodoList.Services.WebApi* project to manage to-do lists in the web API app using REST API; configure the service as a dependency in the *TodoList.WebApp* app.
    * Add a new controller class named `TodoListController` to the *TodoList.WebApp* project; resolve service dependencies using constructor injection.
    * US01: Add a new method to the `TodoListWebApiService` to get the list of to-do lists using the REST API. Use the model classes in the *TodoListApp.WebApi.Models* project.
    * US01: Add a new view to the *TodoList.WebApp* project and a new method to the `TodoListController` class to show the list of to-do lists to the user using the browser UI.
    * US02: Add a new method to the `TodoListWebApiService` to add a new to-do list using the REST API. Use the model classes in the *TodoListApp.WebApi.Models* project.
    * US02: Add a new view to the *TodoList.WebApp* project and a new method to the `TodoListController` class to allow a user to add a new to-do list using the browser UI.
    * US03: Add a new method to the `TodoListWebApiService` to delete an existing to-do list using the REST API. Use the model classes in the *TodoListApp.WebApi.Models* project.
    * US03: Add a new view to the *TodoList.WebApp* project and a new method to the `TodoListController` class to allow a user to delete an existing to-do list using the browser UI.
    * US04: Add a new method to the `TodoListWebApiService` to update an existing to-do list's data using the REST API. Use the model classes in the *TodoListApp.WebApi.Models* project.
    * US04: Add a new view to the *TodoList.WebApp* project and a new method to the `TodoListController` class to allow a user to update an existing to-do list's data using the browser UI.
* T05: Implement Epic 2 backend functionality in the *TodoList.WebApi* application.
* T06: Implement Epic 2 frontend functionality in the *TodoList.WebApp* application.
* T07: Implement Epic 3 backend functionality in the *TodoList.WebApi* application.
* T08: Implement Epic 3 frontend functionality in the *TodoList.WebApp* application.
* T09: Implement Epic 4 backend functionality in the *TodoList.WebApi* application.
* T10: Implement Epic 4 frontend functionality in the *TodoList.WebApp* application.
* T11: Implement Epic 5 backend functionality in the *TodoList.WebApi* application.
* T12: Implement Epic 5 frontend functionality in the *TodoList.WebApp* application.
* T13: Implement Epic 6 backend functionality in the *TodoList.WebApi* application.
* T14: Implement Epic 6 frontend functionality in the *TodoList.WebApp* application.
* T15: Implement Epic 7 functionality in the *TodoList.WebApp* application.
* T16: Implement Epic 8 frontend functionality in the *TodoList.WebApp* application.
* T17: Design and implement good-looking browser UI.


## Delivery Plan

The delivery plan contains a list of technical tasks distributed over the weeks in which these tasks must be delivered.

| Task | Week 1 | Week 2 | Week 3 |
|------|--------|--------|--------|
| T01  | +      |        |        |
| T02  | +      |        |        |
| T03  | +      |        |        |
| T04  |        | +      |        |
| T05  | +      |        |        |
| T06  |        | +      |        |
| T07  | +      |        |        |
| T08  |        | +      |        |
| T09  |        | +      |        |
| T10  |        |        | +      |
| T11  |        | +      |        |
| T12  |        |        | +      |
| T13  |        |        | +      |
| T14  |        |        | +      |
| T15  |        |        | +      |
| T16  |        |        | +      |
| T17  |        |        | +      |


## Weekly Checklists

Use weekly checklists to track your weekly development progress.


### Week 1

The developer's checklist for week 1:

- [ ] T01: C# projects are created and added to the solution file; project dependencies as configured as expected.
- [ ] T01: Built-in .NET code analysis tools are enabled in C# projects; StyleCop NuGet package is added as a dependency to all C# projects and configured properly.
- [ ] T02: The `TodoListDbContext` is added to the *TodoListApp.Services.Database* project and configured as a dependency in the *TodoListApp.WebApi* application.
- [ ] T03: Implement Epic 1 backend functionality in the *TodoList.WebApi* application.
- [ ] T05: Implement Epic 2 backend functionality in the *TodoList.WebApi* application.
- [ ] T07: Implement Epic 3 backend functionality in the *TodoList.WebApi* application.
- [ ] All changes are committed and pushed to the remote repository.
- [ ] There are no major or critical issues or blockers found during building the solution.


### Week 2

The developer's checklist for week 2:

- [ ] T04: Implement Epic 1 frontend functionality in the *TodoList.WebApp* application.
- [ ] T06: Implement Epic 2 frontend functionality in the *TodoList.WebApp* application.
- [ ] T08: Implement Epic 3 frontend functionality in the *TodoList.WebApp* application.
- [ ] T09: Implement Epic 4 backend functionality in the *TodoList.WebApi* application.
- [ ] T11: Implement Epic 5 backend functionality in the *TodoList.WebApi* application.
- [ ] All changes are committed and pushed to the remote repository.
- [ ] There are no major or critical issues or blockers found during building the solution.


#### Week 3

The developer's checklist for week 3:

- [ ] T10: Implement Epic 4 frontend functionality in the *TodoList.WebApp* application.
- [ ] T12: Implement Epic 5 frontend functionality in the *TodoList.WebApp* application.
- [ ] T13: Implement Epic 6 backend functionality in the *TodoList.WebApi* application.
- [ ] T14: Implement Epic 6 frontend functionality in the *TodoList.WebApp* application.
- [ ] T15: Implement Epic 7 functionality in the *TodoList.WebApp* application.
- [ ] T16: Implement Epic 8 frontend functionality in the *TodoList.WebApp* application.
- [ ] T17: Implement Epic 8 frontend functionality in the *TodoList.WebApp* application.
- [ ] All changes are committed and pushed to the remote repository.
- [ ] There are no major or critical issues or blockers found during building the solution.
