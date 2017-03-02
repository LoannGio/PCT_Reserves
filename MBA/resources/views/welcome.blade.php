<!DOCTYPE html>
<html>
<link href="{{ asset('/css/style.css') }}" rel="stylesheet">
@extends('layouts.master')

@section('title')

@section('menu')
    @parent
@stop


@section('content')
  
	<?php

	$sondages = DB::table('Sondage')->whereen_cours(0)->get();

	echo'<table class="tab">';
	    echo'<br>';
	    echo'<caption class="captiontab"><h1>Liste des sondages en cours </h1></caption>';
    	echo'<tr class="trtab">';
    		echo'<th class="thtab">Titre</th>';
    		echo'<th class="thtab">Date de début</th>';
    		echo'<th class="thtab">Date de fin</th>';
   			echo'<th class="thtab">Voir plus</th>';
  		echo'</tr>';
	foreach ($sondages as $sondage) {
		echo'<tr class="trtab">';
			echo'<td class="tdtab">';
	    		echo $sondage->titre;
	    	echo'</td>';
	    	echo'<td class="tdtab">';
	    		echo $sondage->date_debut;
	    	echo'</td>';
	    	echo'<td class="tdtab">';
	    		echo $sondage->date_fin;
	    	echo'</td>';
	    	echo'<td class="tdtab">';	
	    		echo "<a href='sondage/$sondage->id'>Voir plus</a>";
	    	echo'</td>';	
	    echo'</tr>';	
	}
	echo'</table>';
	?>
@stop	
</html>