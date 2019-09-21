<?php


/*ex3.4*/
$nombre=readline("entrez un nombre: ");
if ($nombre>"0"||$nombre=="0"){
        echo "$nombre est positif\n";
   }else{
        echo "$nombre est negative\n";
   }



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

/*5.2*/
$a=readline("entrez un nombre: ");
while($a<10 || $a>20):
  // echo "$a" ;
   if($a<10){
    echo "plus grand  \n" ;
 }elseif($a>20){
     echo "plus petit \n"; 

}
$a=readline("entrez un nombre: ");

endwhile; 

echo "congratulation"

   









?>