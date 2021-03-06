<?php
namespace App\Http\Controllers;
use Illuminate\Http\Request;
use App\Http\Requests;
use Illuminate\Routing\Redirector;
use DB;


class VoteController extends Controller
{
    public function postInfos(Request $request,$s_id,$o_id) {
    	$token = $request->input('g-recaptcha-response');
    	if (strlen($token) > 0) {
            DB::table('OeuvreParSondage')->where([
                ['id', '=', $o_id], 
                ['sondage_id', '=', $s_id],
                ])->increment('nb_votes');
            return redirect('/remercie');
    	} else {
            $error=1;
            //return redirect()->action('WelcomeController@oeuvre', [$s_id,$o_id]);
            return redirect()->action('VoteController@captchaerror', [$s_id,$o_id,$error]);
            //return view('voter')->with(compact('s_id', 'o_id'));
    	}	
    }

    public function captchaerror($s_id,$o_id,$error)
    {
        return view('oeuvre')->with(compact('s_id', 'o_id', 'error'));   
    }
}