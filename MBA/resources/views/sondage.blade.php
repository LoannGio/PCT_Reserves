<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
   <div class="box">                  
                    
     <div class="col-lg-12 text-center">       

<br> <br> 

<?php

echo'<table class="tab">';

$sondage = DB::table('Sondage')->whereid($n)->first();

echo'<tr class=trtab>';

                    
                    
                    echo'<th class=th1>';
                    echo'<hr>';
                   
                    echo'<h2 class="intro-text text-center">'.$sondage->titre;
                     echo'<hr>';
					echo'</h2>';
					echo'</th>';

	
	echo'<th class=th2>';
		echo "<a class='myButton' href='../oeuvres/$sondage->id'>Listes d'oeuvres</a>";
	echo'</th>';
echo'</tr>';

echo'<tr class=trtab>';
	echo'<td class="td1">';
		echo $sondage->description, '<hr>';
	echo'</td>';
	echo'<td class="td2" rowspan="2">';

	echo'</td>';
echo'</tr>';

echo'<tr class=trtab>';
	echo'<td class="td1">';
		echo "Commencer le : ",$sondage->date_debut, '<br>';
		echo "Se finit le : ",$sondage->date_fin, '<br>';
	echo'</td>';

echo'</tr>';	

echo'</table>';


?>

	 </div>
	</div>
@stop	
</html>
