<?php

/*ex2.3*/
$ht=readline("le prix d'un article:");
$n=readline("nombre d'article:");
$tva=$ht*$n;
$ttc=$tva+($tva*0.2);
echo "le prix total: $ttc\n";

?>