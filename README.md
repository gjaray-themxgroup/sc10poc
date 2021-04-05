1. Configure environment based on https://doc.sitecore.com/developers/100/developer-tools/en/set-up-the-environment.html
2. In an admin powershell run `.\docker\init.ps1 -LicenseXmlPath "C:\Path\To\License\license.xml" -SitecoreAdminPassword "SitecorePassword" -SqlSAPassword "SAPassword"`
   1. Be sure to update the license path and passwords in the above commands
3. run `iisreset /stop` to prep the environment for docker compose
4. run `docker-compose up -d`