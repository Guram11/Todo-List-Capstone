# To-do List Application

## Backlog (Full)

| Epic | User Story | Description                                                                     | Priority | Is completed? |
|------|------------|---------------------------------------------------------------------------------|----------|---------------|
| EP1  | US01       | View the list of my to-do lists.                                                | 1        |               |
| EP1  | US02       | Add a new to-do list.                                                           | 1        |               |
| EP1  | US03       | Delete a to-do list.                                                            | 1        |               |
| EP1  | US04       | Edit a to-do list.                                                              | 1        |               |
| EP2  | US05       | View the list of tasks in a to-do list.                                         | 1        |               |
| EP2  | US06       | View the task details page.                                                     | 1        |               |
| EP2  | US07       | Add a new to-do task.                                                           | 1        |               |
| EP2  | US08       | Delete a to-do task.                                                            | 1        |               |
| EP2  | US09       | Edit a to-do task.                                                              | 1        |               |
| EP2  | US10       | Highlight tasks that are overdue.                                               | 1        |               |
| EP3  | US11       | View the list of tasks assigned to me.                                          | 2        |               |
| EP3  | US12       | Filter tasks in my assigned task list.                                          | 5        |               |
| EP3  | US13       | Sort tasks in my assigned task list.                                            | 6        |               |
| EP3  | US14       | Change the status of a task from the list of assigned tasks.                    | 2        |               |
| EP3  | US15       | Search for tasks with specified text in the task title.                         | 7        |               |
| EP4  | US16       | View the list of available tags.                                                | 3        |               |
| EP4  | US17       | Search for tasks with a specific tag added to the task.                         | 8        |               |
| EP4  | US18       | Add a tag to a task.                                                            | 3        |               |
| EP4  | US19       | Remove a tag that is added to a task.                                           | 3        |               |
| EP5  | US20       | View the comments on the task details page.                                     | 4        |               |
| EP5  | US21       | Add a new comment to the task.                                                  | 4        |               |
| EP5  | US22       | Delete a comment that is added to a task.                                       | 4        |               |
| EP6  | US23       | Share a to-do list.                                                             | 10       |               |
| EP6  | US24       | View the list of registered users with which a to-do list is shared with.       | 10       |               |
| EP6  | US25       | Stop sharing a to-do list.                                                      | 10       |               |
| EP7  | US26       | View to-do lists that are shared with me.                                       | 11       |               |
| EP7  | US27       | Edit a to-do list that is shared with me.                                       | 13       |               |
| EP7  | US28       | Re-share a to-do list that is shared with me.                                   | 15       |               |
| EP7  | US29       | Distinguish between my to-do lists and the to-do lists that are shared with me. | 11       |               |
| EP8  | US30       | View the list of tasks in a to-do list that is shared with me.                  | 12       |               |
| EP8  | US31       | Add a new task to a to-do list that is shared with me.                          | 14       |               |
| EP8  | US32       | Delete a task in a to-do list that is shared with me.                           | 14       |               |
| EP8  | US33       | Edit a task in a to-do list that is shared with me.                             | 14       |               |
| EP8  | US34       | Re-assign the task that is shared with me.                                      | 16       |               |
| EP9  | US35       | Sign up                                                                         | 9        |               |
| EP9  | US36       | Sign in                                                                         | 9        |               |
| EP9  | US37       | Sign out                                                                        | 9        |               |


## User Stories

This document contains a list of [functional requirements](https://en.wikipedia.org/wiki/Functional_requirement) that the To-Do List application must meet. The requirements are described as [user stories](https://en.wikipedia.org/wiki/User_story), which are requirements expressed from the perspective of an end-user.

For convenience, user stories are grouped into epics, which contain only user stories on a specific topic.


### Epic 1 (EP01): To-Do Lists

#### User Story 1 (US01): View a list of my to-do lists.

As the to-do list user, I want to see a list of all the to-do lists I've created, so I can manage them or view to-do list details.

TODO - what should contain? name, description, number of tasks, is shared.

#### User Story 2 (US02): Add a new to-do list.

As the to-do list user, I want to create a new to-do list, so I can add new items to it or manage the one I created.

#### User Story 3 (US03): Delete a to-do list.

As the to-do list owner, I want to delete an existing to-do list, so I can no longer see it listed in my to-do lists.

#### User Story 4 (US04): Edit a to-do list.

As the to-do list owner, I want to change the properties of an existing to-do list, so I can have a to-do list with different properties.


### Epic 2 (EP2): Tasks

#### User Story 5 (US05): View the list of tasks in a to-do list.

As the to-do list owner, I want to see the list of all tasks in my to-do list, so I can manage them or view task details.

#### User Story 6 (US06): View the task details page.

As the to-do list owner, I want to see the task details on the task details page, so that I can check the task properties out.

#### User Story 7 (US07): Add a new to-do task.

As the to-do list owner, I want to add a new task to my to-do list, so I can see this task on the to-do list page.

#### User Story 8 (US08): Delete a to-do task.

As the to-do list owner, I want to delete an existing task from my to-do list, so I can no longer see it listed in the to-do list.

#### User Story 9 (US09): Edit a to-do task.

As the to-do list owner, I want to change the properties of an existing to-do task, so I can have a to-do task with different properties.

#### User Story 10 (US10): Highlight tasks that are overdue.

As the to-do list owner, I want expired tasks to be highlighted in a different color or with some kind of notification, so that I can easily distinguish expired tasks from other tasks.


### Epic 3 (EP3): Assigned Tasks

#### User Story 11 (US11): View the list of tasks assigned to me.

As the to-do list user, I want to see a list of all the tasks assigned to me, so I can see the task details and change their status. The task is assigned by default to the user who created it.

#### User Story 12 (US12): Filter tasks in my assigned task list.

As the to-do list user, I want to filter the tasks in the assigned task list by status, so I can only see tasks that match the task status I specified as a criterion.

#### User Story 13 (US13): Sort tasks in my assigned task list.

As the to-do list user, I want to sort the tasks in the assigned task list by task name or due date, so that I can see the items in the assigned task list in the order I want.

#### User Story 14 (US14): Change the status of a task from the list of assigned tasks.

As the to-do list user, I want to change the status of a task from the assigned task list, so that I don't have to go to the task's detail page.

#### User Story 15 (US15): Search for tasks with specified text in the task title.

As the to-do list user, I want to search for tasks with a specified test in the task title, so that I can easily find tasks.


### Epic 4 (EP4): Tagging Tasks

#### User Story 16 (US16): View the list of available tags.

As the to-do list user, I want to see the list of all tags added to all tasks in the to-do lists I have access to.

#### User Story 17 (US16): Search for tasks with a specific tag added to the task.

As the to-do list user, I want to search for tasks with a specific tag added to the task, so that I can have a list of all tasks related to a certain topic.

#### User Story 18 (US18): Add a tag to a task.

As the to-do list owner or editor, I want to add a tag to a specific task on the task edit page, so that I can easily navigate to tasks that have a specific tag added to them.

TODO

#### User Story 19 (US19): Remove a tag that is added to a task.

As the to-do list owner or editor, I want to remove a tag that is added to a task, so that all users will not see this tag on the task details page.


### Epic 5 (EP5): Commenting Tasks

#### User Story 20 (US20): View the comments on the task details page.

As the to-do list user, I want to see the list of comments on the task details page, so that I can see all comments added to the specific task by any user.

#### User Story 21 (US21): Add a new comment to the task.

As the to-do list owner or editor, I want to add a new comment to the specific task on the task edit page, so the comment is added to the task details page.

#### User Story 22 (US22): Delete a comment that is added to a task.

As the to-do list owner, I want to remove a comment added to the specific task.


### Epic 6 (EP6): Sharing To-Do Lists

#### User Story 22 (US23): Share a to-do list.

As the to-do list owner, I want to share an existing to-do list with another registered user, so that the user has full or read-only access to my to-do list.

#### User Story 24 (US24): View the list of registered users with whom a to-do list is shared.

As the to-do list owner or editor, I want to see a list of registered users who have been granted access to the to-do list, so that I can stop sharing the list with a specified user.

#### User Story 25 (US25): Stop sharing a to-do list.

As the to-do list owner or editor, I want to stop sharing a to-do list with the registered user who has access to the list, so that the user no longer has access to the list.


### Epic 7 (EP07): Shared To-Do Lists

#### User Story 26 (US26): View to-do lists that are shared with me.

As the to-do list viewer or editor, I want to see all to-do lists shared with me in the list of my to-do lists, so I can manage them or view to-do list details.

#### User Story 27 (US27): Edit a to-do list that is shared with me.

As the to-do list editor, I want to change the properties of an existing to-do list, so I can have a to-do list with different properties.

#### User Story 28 (US28): Re-share a to-do list that is shared with me.

As the to-do list editor, I want to re-share an existing to-do list with another registered user so that the user has full or read-only access to my to-do list.

#### User Story 29 (US29): Distinguish between my to-do lists and the to-do lists that are shared with me.

As the to-do list viewer or editor, I want to see an icon or some kind of notification indicating that a to-do list has been shared with me, so that I can differentiate my to-do lists from those that have been shared with me.


### Epic 8 (EP08): Shared Tasks

#### User Story 30 (US30): View the list of tasks in a to-do list that has been shared with me.

As the to-do list viewer or editor, I want to see the list of all tasks in a to-do list that is shared with me, so I can view task details or manage them in case I have full access to the to-do task.

#### User Story 31 (US31): Add a new task to a to-do list that is shared with me.

As the to-do list editor, I want to create a new task to a to-do list that is shared with me, so all users can see this task in the to-do list.

#### User Story 32 (US32): Delete a task in a to-do list that is shared with me.

As the to-do list editor, I want to delete an existing task from a to-do list that is shared with me, so all other users will no longer see it listed in the to-do list.

#### User Story 33 (US33): Edit a task in a to-do list that is shared with me.

As the to-do list editor, I want to change the properties of an existing task in a to-do list that is shared with me, so all other users can have the task with different properties.

#### User Story 34 (US34): Re-assign the task that is shared with me.

As the to-do list user, I want to re-assign a task to the to-do list owner or any user that the to-do list is shared with.


### Epic 9 (EP09): Users

#### User Story 35 (US35): Sign up

As the unauthorized user, I want to sign up (register) for the Todo List website, so that I can sign in (login) to the website.

#### User Story 36 (US36): Sign in

As the unauthorized user, I want to sign in (login) to the Todo List website, so that I can use the features provided by the website.

#### User Story 37 (US37): Sign out

As the authorized user, I want to sign out (logout) of the Todo List website, so that I no longer have access to the features the website provides.


### Epic 10 (EP09): Copy

As the to-do list user, I want to copy a task.
