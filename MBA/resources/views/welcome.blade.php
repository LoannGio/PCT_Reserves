<!DOCTYPE html>
<html>

@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
  
	<?php

	$sondages = DB::table('Sondage')->whereen_cours(0)->get();
	echo'<br>';
	echo'<h1 class="titre">Liste des sondages en cours </h1>';
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
	    		echo "<a href='sondage/$sondage->id'>Voir plus</a>";
	    	echo'</td>';	
	    echo'</tr>';	
	}
	echo'</tbody>';
	echo'</table>';
	?>
@stop	
</html>