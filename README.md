# MPRaddit_JJ

-Bug: Når "Comment" eller "ThreadPost" er lavet. Gemmes votes ikke i databasen, først når man har reloadet hjemmesiden. Fordi Cross-Origin Request Blocked: The Same Origin Policy disallows reading the remote resource at localhost:5001/api/comment/vote. (Reason: CORS header ‘Access-Control-Allow-Origin’ missing). Status code: 500


#Dokumation--------------


Den onsdag 5-10-2022 oprettede vi vores Bladzor project forbundet med github uden problemer. 
Fredag den 07-10-2022  Snakkede vi om hvordan vi ville have vores app til at se ud og hvordan den skulle fungerer. Så lavede vi vores UML-diagram. 
Vi lavede også et logo til vores reddit side.
Vi begyndte også på vores bladzor hvor vi fik oprette alle vores klasser.


Lørdag den 08-10-2022 Puttede nogle af api “post”, “put” og “get” for blandt andet at teste dem.

tirsdag den 11-10-2022 lavede der Web API “Minimal API” og derefter om på klasserne så de kan “snakke sammen” ved hjælp af id, fordi vi havde helt glemt at Sqlite ikke supporter nedarvninger/subklasse.

Onsdag den 12-10-2022 fik lavet meget på forsiden på vores hjemmeside(Næsten færdig med den forhåbentligt). Arbejde med api, men gik lidt galt, som gjorde det tog lang tid, fordi der bl.a skulle ændres i UML diagrammet igen. Derfor ikke helt færdig med api, som gør hjemmesiden og entity framework apie
n kan kommunikere.

Mandag den 25-10-2022 Fik lavet mere på api, noget galt med http client i blazor, derfor skal vi have hjælp til at fixe det på onsdag 27-10-2022. For ellers skal et nyt projekt laves og sætte alle vores ting ind, som vi gerne vil undgå

Onsdag den 26-10-2022 Problemer med projektet, fordi den siger “Cannot consume scoped service 'System.Net.Http.HttpClient' from singleton 'MiniProjectRaddit.Service.DbService'.” Når vi vil kommunikere med blazor og httpclient. Prøvede lidt tid, men vi ville i bruge for meget tid på det, derfor brugte vi Softwarearkitektur “TodoList blazor project”, fordi det virker og vi kan derfor spare tid. 
Vi kunne ikke få forbindelse imellem API program og blazor, fordi “CORS” blocked det, selvom vi  har CORS i vores api program. Derfor brugte vi “hardcore data”. Gav mulighed for vi kunne fortsætte med at lave på hjemmesiden.

Torsdag den 27-10-2022 Vi fandt ud af med CORS at den blocker http, men det skal være https. http har 5000 og https har 5001. Testet det derefter imellem postman og api'en for at være sikker på det hele vil virke imellem blazor og api'en




Fredag den 28-10-2022 Fik sat Blazor programmet og Api programmet sat i en mappe og oploadet det til github. Opdateret lidt visuelt, fixet bugs, men 1 bug med CORS ladet vi værre, fordi det ikke ødelagde hjemmesiden .Testet at api virker med dotnet build, dotnet ef database update og dotnet run, som det gjorde på vores pc’er. Fik afleveret opgaven.

Lørdag den 29-10-2022 testede vi lidt videre og se om vi kunne finde nogle bugs. Fandt den bug med CORS med "Coment"og "treadPost", men ødelægger ikke hjemmesiden, fordi den bare skal refreshed efter "Comment" eller "ThreadPost" bliver lavet
