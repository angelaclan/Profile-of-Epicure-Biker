<?php
    $a=readline("enter a number: ");
    while ($a<10 || $a>20):
        if($a<10){
            echo "bigger\n";
        }elseif($a>20){
            echo "smaller\n";
        }
        $a=readline("enter a number: ");
    endwhile;
