1. Configure environment based on https://doc.sitecore.com/developers/100/developer-tools/en/set-up-the-environment.html
2. In an admin powershell run `.\docker\init.ps1 -LicenseXmlPath "C:\Path\To\License\license.xml" -SitecoreAdminPassword "SitecorePassword" -SqlSAPassword "SAPassword"`
   1. Be sure to update the license path and passwords in the above commands
3. run `iisreset /stop` to prep the environment for docker compose
4. run `docker-compose up -d`
5. confirm that you have a working sitecore instance by navigating to https://cm.sctenpoc.localhost/
6. login to sitecore https://cm.sctenpoc.localhost/sitecore/shell using the password defined in step 2
   1. sometimes the ID server redirects to http, just change url to https
7. Navigate to the Control Panel and Populate Solr Schema
8. Naviage to content editor and publish the site