<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Calculate Result</title>

<!--  Link external CSS Master file containing all other CSS files -->
<link href="styles.css" rel="stylesheet" type="text/css" />

</head>

<body>

<div class="container">

<?php
	
# get variables and bind them
if (empty ($_POST['reload']) )
	{
		$acHeading 	= "please enter aircraft heading";
		$acAltitude	= "please enter aircraft altitude";
		$wHeading 	= "please enter wind heading";
		$wSpeed 		= "please enter wind speed";
		$side 		= '';
		$correction = '';
	}
else {
		if (is_numeric($_POST['acHeading']) ) 
			{
				if ($_POST['acHeading'] > 360)
					{
						$acHeading 	= "max value is 360!";
					} else {
						$acHeading = $_POST['acHeading'];
					}
			} else {
				$acHeading 	= "please enter aircraft heading";
				unset ($_POST['reload']);
			}
		
		if (is_numeric($_POST['acAltitude']) ) 
			{
				$acAltitude = $_POST['acAltitude'];
			} else {
				$acAltitude	= "please enter aircraft altitude";
			}
		
		if (is_numeric($_POST['windHeading']) ) 
			{
				if ($_POST['windHeading'] > 360)
					{
						$wHeading 	= "max value is 360!";
					} else {
						$wHeading = $_POST['windHeading'];
					}
			} else {
				$wHeading 	= "please enter wind heading";
				unset ($_POST['reload']);
			}

		if (is_numeric($_POST['windSpeed']) ) 
			{
				$wSpeed = $_POST['windSpeed'];
			} else {
				$wSpeed = "please enter wind speed";		
			}

}

# calculate side

// create new variable for full circle value
$circle = 360;

// check if aircraft heading is bigger then wind heading
if ($acHeading > $wHeading)
	{
		// substract acHeading from wHeading and check if result is bigger then 180
		// set offset variable accordingly
		$correction = $acHeading - $wHeading;
		$side = "left";
		if ($correction > 180)
			{
				$correction = ($circle - $acHeading) + $wHeading;
				$side = "right";
			}
	}
else
	{
		// substract  wHeading from acHeading and check if result is bigger then 180
		// set offset variable accordingly
		$correction = $wHeading - $acHeading;
		$side = "right";
		if ($correction > 180)
			{
				$correction = ($circle - $wHeading) + $acHeading;
				$side = "left";
			}
	}

echo "<h1>Battle Of Stalingrad</h1>\n";
echo "<h2>Wind Correction Calculator</h2>\n";

echo "<form id=\"bombsightTableForm\" name=\"calculate\" action=\"Input.php\" method=\"post\">\n";

echo "<p class=\"remark\">fields with * are mandatory</p>\n";
   
echo "	<fieldset id=\"inputs\">\n";
echo "		<label>Aircraft Altitude in meter:</label>\n";
if (is_numeric($acAltitude) ) 
			{
				echo "		<input type=\"text\" class=\"form\" name=\"acAltitude\" value=\"$acAltitude\" ><br>\n";
			} else {
				echo "		<input type=\"text\" class=\"form\" name=\"acAltitude\" value=\"\" placeholder=\"$acAltitude\" ><br>\n";
			}

echo "		<label class=\"mandatory\">Aircraft Heading in degrees:</label>\n";
if (is_numeric($acHeading) ) 
			{
				echo "		<input type=\"text\" class=\"form\" name=\"acHeading\" value=\"$acHeading\"><br>\n";
			} else {
				echo "		<input type=\"text\" class=\"form\" name=\"acHeading\" value=\"\" placeholder=\"$acHeading\"><br>\n";
			}
echo "		<label class=\"mandatory\">Wind Direction in degrees:</label>\n";
if (is_numeric($wHeading) ) 
			{
				echo "		<input type=\"text\" class=\"form\" name=\"windHeading\" value=\"$wHeading\" ><br>\n";
			} else {
				echo "		<input type=\"text\" class=\"form\" name=\"windHeading\" value=\"\"placeholder=\"$wHeading\" ><br>\n";
			}
echo "		<label>Wind Speed in m/s:</label>\n";
if (is_numeric($wSpeed) ) 
			{
				echo "		<input type=\"text\" class=\"form\" name=\"windSpeed\" value=\"$wSpeed\" ><br>\n";
			} else {
				echo "		<input type=\"text\" class=\"form\" name=\"windSpeed\" value=\"\" placeholder=\"$wSpeed\"><br>\n";
				echo "	</fieldset>\n";
			}
			
if (empty ($_POST['reload']) )
	{
		echo "		<br>\n";
		echo "		<br>\n";	
		echo "		<br>\n";
		echo "		<br>\n";
		echo "		<br>\n";
		echo "		<br>\n";	
		echo "		<br>\n";
		echo "		<br>\n";				
	}
else
	{
		echo "	<fieldset id=\"results\">\n";
		echo "		<label class=\"first\">Wind Correction:</label>\n";
		echo "		<input type=\"text\" name=\"windCorrection\" value=$side ><br>\n";
		
		echo "		<label>by degrees:</label>\n";
		echo "		<input type=\"text\" name=\"correction\" value=$correction ><br>\n";
	}

// hidden field to manage first and reloaded access of form
echo "		<input type=\"hidden\" name=\"reload\" value=1 >\n";
echo "	</fieldset>\n";
   
echo "	<fieldset id=\"action\">\n";
echo "		<input type=\"submit\" id=\"doIt\" value=\"Calculate\">\n";
echo "	</fieldset>\n";
   
echo "</form>\n";

?>

</div>

</body>
</html>