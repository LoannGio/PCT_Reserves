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
	<?php

	$sondages = DB::table('Sondage')->whereen_cours(1)->get();
	echo'<br>';

                    echo'<hr>';
                    echo'<h2 class="intro-text text-center">Liste des sondages en cours';
                  
                    echo'</h2>';
                    echo'<hr>';

	
	echo'<table id="example" class="display" cellspacing="0" width="80%">';
    	echo'<thead>';
    		echo'<th>Titre</th>';
    		echo'<th>Date de début</th>';
    		echo'<th>Date de fin</th>';
   			echo'<th>Voir plus</th>';
  		echo'</thead>';
  		echo '<tbody>';
	foreach ($sondages as $sondage) {
		echo'<tr>';
			echo'<td>';
	    		echo $sondage->titre;
	    	echo'</td>';
	    	echo'<td>';
	    		echo $sondage->date_debut;
	    	echo'</td>';
	    	echo'<td>';
	    		echo $sondage->date_fin;
	    	echo'</td>';
	    	echo'<td>';	
	    		echo "<a class='myButton' href='sondage/$sondage->id'>Voir plus</a>";
	    	echo'</td>';	
	    echo'</tr>';	
	}
	echo'</tbody>';
	echo'</table>';
	?>
	 </div>
	</div>
@stop	
</html>