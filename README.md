# Entity Framework - Code First - ASP.NET Session Mode SQL
For storing session data in SQL databases when you're using Entity Framework Code First to create the schema.

## Entity Framework Code First Classes
There are only two entities (POCO classes) that you need to add to your solution. They are ASPStateTempApplication and ASPStateTempSession. After you add these two models to your project, you'll want to add DbSet's to your DbContext class and then create a migration.

In addition to the entities and migration, you'll also need add a blank migration for the SessionSql Stored procedures. The stored procedures for migrating up and down are located in the resource file SqlScripts.resx. In the new Migration, you'll notice that for the up and down methods for running the scripts for the stored procedures, that it is slicing up the script to handle GO statements and blank lines which are not supported in the Sql() method.

Lastly, add or change your session element in the web.config. You'll need to update the connection string to point at your database, but then you should be good to go.

To run the example, simply start debugging the solution and navigate to the set the session action and then to the checksession to see your Session variable is being stored. Stop and restart the debugging session and you should see that the session was restored and available. If you remove the session node and you stop and restart the site, and then navigate to the checksession first, it should return a yellow screen of death stating that the session variable was not set! 

Hopefully this makes it easier for you to use Sql for ASP.NET Sessions when using Entity Framework Code First!
