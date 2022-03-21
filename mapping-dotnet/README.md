# Backend Coding Challenge: Mapping Challenge

### acceptance criteria:
 - `Article` is correctly mapped to `ArticleDTO` (see `ArticleController#list` and `ArticleController#details`) and is emitted as a JSON from the Controllers
 - the collection of `ArticleBlockDto` in `ArticleDTO` is sorted after `sortIndex` in `ArticleBlockDTO`
 - in case an `Article` cannot be found via ID, a 404 shall be shown (see `ArticleController#details`)
 - optional: in case a new implementation of `ArticleBlock` is created and no mapping is implemented, the user shall get an info

### general conditions:
 - DB Models and DTO Models can be extended with Interfaces/Properties
 - Existing field of Models and DTOs shall not be modified
 - the package structure shall not be modified
 - Any other NuGet dependencies can be added