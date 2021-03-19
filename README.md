<h1>OData Expirement</h1>

<h3>To Test:</h3>
dotnet ef database add inital
dotnet ef database update

<h3>Test Endpoit</h3>
Web Api - /odata/Customers?$filter=CountryId eq 'CH'&$select=Name
          /odata/Customers?$filter=CountryId eq 'CH'
