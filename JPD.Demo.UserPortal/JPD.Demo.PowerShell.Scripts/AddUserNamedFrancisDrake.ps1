#
# AddUserNamedFrancisDrake.ps1
#

$addresses = @()
$addresses += [pscustomobject]@{
    'addressline1' = '9764 Jeopardy Lane';
    'addressline2' = '';
    'city' = 'Chicago';
    'state' = 'IL';
    'zipcode' = '60195';
    'addresstype' = '1'
}

$interests = @()
$interests += [pscustomobject]@{
   'name'= 'Pirating';
   'description' = 'Doing pirate stuff.'
}

$interests += [pscustomobject]@{
   'name'= 'Baseball';
   'description' = 'The one constant through all the years, has been baseball.'
}

$user = [pscustomobject]@{
	firstName = 'Francis'
	lastName = 'Drake'
	age = '49'
    addresses = $addresses
    interests = $interests
	}

$json = $user | ConvertTo-Json

Write-Host "Adding the new user..."

$response = Invoke-RestMethod 'https://localhost:44389/api/Users/add' -Method Post -Body $json -ContentType 'application/json'

Write-Host "Add user complete."

Write-Host "Dumping the response..."

$response
