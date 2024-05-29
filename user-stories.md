# To-do List Application

This document contains a list of [functional requirements](https://en.wikipedia.org/wiki/Functional_requirement) that the To-Do List application must meet. The requirements are described as [user stories](https://en.wikipedia.org/wiki/User_story), which are requirements expressed from the perspective of an end-user.

User stories are often expressed in one or two sentences, structured as follows:

*“As a [persona], I [want to], [so that].”*


## User Personas

In a user story, a user persona helps the development team understand who the user story is for.

* *A to-do list user* is the web application user who manages the to-do lists and tasks he has access to.
* *A to-do list owner* is a user who created a specific to-do list and is able to edit or remove it.
* *A to-do list viewer* is a user who is granted read-only access to a specific to-do list and related tasks.
* *A to-do list editor* is a user who is granted full access to a specific to-do list and related tasks.
* *An unauthorized user* is a user who has not signed in to the web application.
* *An authorized user* is a user who has been sighed in to the web application. The user is stay authorized until it signed out.


## User Stories

For convenience, user stories are grouped into epics, which contain only user stories on a specific topic.


### Epic 1 (EP01): To-Do Lists

#### User Story 1 (US01): View a list of my to-do lists.

As a to-do list user, I want to see a list of all the to-do lists I've created, so I can manage them or view to-do list details.

#### User Story 2 (US02): Add a new to-do list.

As a to-do list user, I want to create a new to-do list and set its properties (list title and description) so I can manage the one I created or add new tasks to it.

#### User Story 3 (US03): Delete a to-do list.

As a to-do list owner, I want to delete an existing to-do list so I can no longer see it listed in my to-do lists.

#### User Story 4 (US04): Edit a to-do list.

As a to-do list owner, I want to change the properties of an existing to-do list so I can have a to-do list with different properties.


### Epic 2 (EP02): Tasks

#### User Story 5 (US05): View the list of tasks in a to-do list.

As a to-do list owner, I want to see the list of all tasks in my to-do list, so I can manage them or view task details.

#### User Story 6 (US06): View the task details page.

As a to-do list owner, I want to see the task details on the task details page so that I can check the task properties out.

#### User Story 7 (US07): Add a new to-do task.

As a to-do list owner, I want to add a new task to my to-do list so I can see this task on the to-do list page. When a task is create, it must be assigned to the user who created it.

#### User Story 8 (US08): Delete a to-do task.

As a to-do list owner, I want to delete an existing task from my to-do list so I can no longer see it listed in the to-do list.

#### User Story 9 (US09): Edit a to-do task.

As a to-do list owner, I want to change the properties of an existing to-do task so I can have a to-do task with different properties.

#### User Story 10 (US10): Highlight tasks that are overdue.

As a to-do list owner, I want expired tasks to be highlighted in a different color or with some kind of notification so that I can easily distinguish expired tasks from other tasks.


### Epic 3 (EP03): Assigned Tasks

#### User Story 11 (US11): View a list of tasks assigned to me.

As a to-do list user, I want to see a list of tasks assigned to me so I can see the task details and change their status. By default, a task is assigned to the user who created it.

#### User Story 12 (US12): Filter tasks in my assigned task list.

As a to-do list user, I want to filter the tasks in the assigned task list by status, so I can only see tasks that match the task status I specified as a criterion. By default, only active tasks should be displayed.

#### User Story 13 (US13): Sort tasks in my assigned task list.

As a to-do list user, I want to sort the tasks in the assigned task list by task name or due date so that I can see the items in the assigned task list in the order I want.

#### User Story 14 (US14): Change the status of a task from the list of assigned tasks.

As a to-do list user, I want to change the status of a task from the assigned task list so that I don't have to go to the task's detail page.


### Epic 4 (EP04): Search

#### User Story 15 (US15): Search for tasks.

As a to-do list user, I want to search for tasks based on specific criteria so that I can navigate to the task details. A user should be able to search for tasks by task title, task creation date, or task due date, depending on which criteria is specified.

#### User Story 16 (US16): Highlight tasks that are overdue on the search result page.

As a to-do list user, I want expired tasks to be highlighted in a different color or with some kind of notification on the search result page so that I can easily distinguish expired tasks from other tasks.


### Epic 5 (EP04): Tagging Tasks

#### User Story 17 (US17): View a list of tags on the task details page.

As a to-do list user, I want to see the list of tags on the task details page so that I can see all the tags added to the specific task by any user.

#### User Story 18 (US18): View a list of all tags.

As a to-do list user, I want to see the list of all the tags added to tasks in the to-do lists that I have access to, so that I can navigate to a list of tasks tagged with a specific tag.

#### User Story 19 (US19): View a list of tasks tagged by a specific tag.

As a to-do list user, I want to view a list of tasks tagged with a certain tag so that I can navigate to the task tagged with a certain tag.

#### User Story 20 (US20): Add a tag to a task.

As a to-do list owner or editor, I want to add a tag to a specific task on the task edit page, so that I can see that tag on the task's details page.

#### User Story 21 (US21): Remove a tag that is added to a task.

As a to-do list owner or editor, I want to remove a tag that is added to a task, so that I don't see that tag on the task's details page.


### Epic 6 (EP05): Commenting Tasks

#### User Story 22 (US22): View the comments on the task details page.

As a to-do list user, I want to see the list of comments on the task details page so that I can see all comments added to the specific task by any user.

#### User Story 23 (US23): Add a new comment to the task.

As a to-do list owner or editor, I want to add a new comment to the specific task on the task edit page, so the comment is added to the task details page.

#### User Story 24 (US24): Delete a comment that is added to a task.

As a to-do list owner, I want to remove a comment added to the specific task so that I don't see that comment on the task's details page.

#### User Story 25 (US25): Edit a comment that is added to a task.

As a to-do list owner, I want to edit a comment added to the specific task so that I can see a new comment text on the task's details page.


### Epic 7 (EP06): Users

#### User Story 26 (US26): Sign up

As an unauthorized user, I want to sign up (register) for the To-do List website so that I can sign in (login) to the website.

#### User Story 27 (US27): Sign in

As an unauthorized user, I want to sign in (login) to the To-do List website so that I can use the features provided by the website.

#### User Story 28 (US28): Sign out

As an authorized user, I want to sign out (logout) of the To-do List website so that I no longer have access to the features the website provides.

#### User Story 29 (US29): Restore password

As an unauthorized user, I want to send password recovery instructions to the email address I used when I signed up with the website so that I can access the website if I forget my password.


### Epic 8 (EP08): Menu

As a to-do list user, I want to use the application's menu so that I can easily navigate to the app's most important web pages.
