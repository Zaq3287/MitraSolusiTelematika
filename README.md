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

- If you want to check manually, you can use the following url:<br />
  GET -> displays all data contained in the list<br />
  http://localhost:{port}/api/players<br />
  GET -> displays data based on Id<br />
  http://localhost:{port}/api/players/{id}<br />
  GET ->  display data based on place of birth<br />
  http://localhost:{port}/api/players/birthPlace/{birthPlace}<br />
  GET -> a custom api used to display connection strings<br />
  http://localhost:{port}/api/settings<br />
  POST -> insert new data into the list<br />
  http://localhost:{port}/api/players<br />
