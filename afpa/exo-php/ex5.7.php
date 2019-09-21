<!DOCTYPE HTML>  
<html>

<body>  

<?php
 // Phase 1 is about to generate the proper form for the user to send his/her data.
?>

<h2>PHP Form Example</h2>
<p><span class="error">* required field</span></p>
<form method="get" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">  
<?php 
  for ( $x = 0 ; $x < 10 ; $x++) {
?>
    <?php echo $x; ?> entry: 
    <input type="text" name="<?php echo $x; ?>" value=""> 
    <br/>
<?php
  }
 ?>
  <input type="submit" name="submit" value="Submit">  
</form>

<?php
 // Phase 2 is about to treat the user data for what we need it.
?>

<?php
if ( empty( $_POST[0] ) ) exit;

echo "hello"
?>

</body>
</html>