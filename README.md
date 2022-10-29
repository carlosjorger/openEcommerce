# OpenEcommerce

## Table of contents
<!-- - [Quick start](#quick-start) -->
- [Status](#status)
- [Backend/.NET CORE](#backend)
- [Author](#author)
## Backend

### Onion Architecture
We split the backend in three layers:
- Domain: Main entities and his relations
- Infrastructure: Access to the database through EntityFramwork
- Application: The logic of the command and querys methods
### CQRS / MediantR
We implement CQRS using MediantR in Application layer, then We use the mediator in the controller of the api
### Author
* Author  : carlosJorgeR