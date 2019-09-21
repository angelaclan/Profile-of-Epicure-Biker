<?php






/*ex3.6*/
$noma=readline("entrez le premier nombre: ");
$nomb=readline("entrez le deuxiem nombre: ");
if($noma==0 || $nomb==0){
    echo "nul\n";
}elseif(($noma>0 && $nomb<0) ||($noma<0 && $nomb>0)){
    echo "negatif\n";
}elseif(($noma<0 && $nomb<0)||($noma>0 && $nomb>0)){
    echo "positif\n";
}


   









?>