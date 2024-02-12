# Amandus, 20240212:
# Mitra Solusi Telematika
# Programmer Test Net Core Junior

- First clone this repository by:
git clone "https://github.com/Zaq3287/MitraSolusiTelematika"
- Make sure you have .NET 8 installed
- Then open the 'MitraSolusiTelematics.sln' file, here I use Visual Studio 2022.
- Then just run the program.

- For web api testing, you can use Swagger.
![image](https://github.com/Zaq3287/MitraSolusiTelematika/assets/98646806/0828786a-422f-4bdc-be45-ed534971afd3)

- If you want to check manually, you can use the following url:__
  GET -> displays all data contained in the list__
  http://localhost:{port}/api/players__
  GET -> displays data based on Id__
  http://localhost:{port}/api/players/{id}__
  GET ->  display data based on place of birth__
  http://localhost:{port}/api/players/birthPlace/{birthPlace}__
  GET -> a custom api used to display connection strings__
  http://localhost:{port}/api/settings__
  POST -> insert new data into the list__
  http://localhost:{port}/api/players__
