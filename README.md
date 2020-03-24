Task:
Make a backend to a service on ASP.NET Core 2+.

Task description:
There is a service where the client can register, log in and ask a few keywords and products to monitor the position of the product keywords on amazon.com.
There are independent parsers for amazon.com pages. Parsers periodically ask the server if there is a parsing task, they can receive it and send the result of the parsing, where the product is by keyword, how many advertisements are in front of your keyword.
There is a client part in the browser (FrontEnd SPA), which allows users to register, login, add tasks for monitoring keywords, show results in the form of tables.

Details:
The client part and parsers work through the API, prototypes of the methods of this API need to be written. Develop DAL (without real work with the database). Develop an API request structure. The code should be written so that it can be easily covered by automatic tests. What database would you recommend to use for this task if you need to track 10,000,000 keywords daily?

______________________________________________________________________________________________________________________________________

Solution:
Performed in the form of Swagger spec without the implementation of methods with a minimum of comments on the expected solution paths. DAL BLL Domain not implemented - prototypes.

I suppose the relational database will do the job perfectly.
1 part - standard suite for "individual user" accounts
2 part - Task: Id(int) / UserId / GoodName / KeyWord / WordRank / AdsCount

You can normalize, but I don't see strong reasons for it.
Regarding automatic tests, I can only offer a weak dependencies.

Swagger screenshot:
https://clip2net.com/s/46zfw22
