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
$acHeading 	= $_POST["heading"];
$altitude 	= $_POST["altitude"];
$wHeading	= $_POST["windHeading"];
$wSpeed		= $_POST["windSpeed"];

# calculate side

// create new variable for full circle value
$circle 		= 360;

// check if aircraft heading is bigger then wind heading
if ($acHeading > $wHeading)
	{
		// substract acHeading from wHeading and check if result is bigger then 180
		// set offset variable accordingly
		$correction = $acHeading - $wHeading;
		$side 		= "left";
		if ($correction > 180)
			{
				$correction = ($circle - $acHeading) + $wHeading;
				$side 		= "right";
			}
	}
else
	{
		// substract  wHeading from acHeading and check if result is bigger then 180
		// set offset variable accordingly
		$correction = $wHeading - $acHeading;
		$side 		= "right";
		if ($correction > 180)
			{
				$correction = ($circle - $wHeading) + $acHeading;
				$side 		= "left";
			}
	}

echo "<form id=\"bombsightTableForm\" name=\"calculate\" action=\"Result.php\" method=\"post\">\n";
   
echo "   <fieldset id=\"input\">\n";
echo "      <label>Aircraft Altitude in meter:</label>\n";
echo "      <input type=\"text\" name=\"altitude\" value=$altitude ><br>\n";

echo "      <label>Aircraft Heading in degrees:</label>\n";
echo "      <input type=\"text\" name=\"heading\" value=$acHeading ><br>\n";

echo "      <label>Wind Direction in degrees:</label>\n";
echo "      <input type=\"text\" name=\"windHeading\" value=$wHeading ><br>\n";

echo "      <label>Wind Speed in m/s:</label>\n";
echo "      <input type=\"text\" name=\"windSpeed\" value=$wSpeed ><br>\n";

echo "      <label>Wind Correction:</label>\n";
echo "      <input type=\"text\" name=\"windCorrection\" value=$side ><br>\n";

echo "      <label>by:</label>\n";
echo "      <input type=\"text\" name=\"correction\" value=$correction ><br>\n";
echo "    </fieldset>\n";
   
echo "   <fieldset id=\"action\">\n";
echo "      <input type=\"submit\" id=\"doIt\" value=\"Calculate\">\n";
echo "   </fieldset>\n";
   
echo "   </form>\n";

?>

</div>

</body>
</html>