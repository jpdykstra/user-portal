#
# This script will search for users with a first or last name of Lee.
#
# NOTE: The JPD.Demo.Service project needs to be running in order for this script to connect to the server.

Invoke-RestMethod -Uri 'https://localhost:44389/api/Users/searchbyname/lee' -Method Get