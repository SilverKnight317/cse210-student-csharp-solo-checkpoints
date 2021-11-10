using System.Collections.Generic;
using _08_rfk.Casting;
using _08_rfk.Services;


namespace _08_rfk.Scripting
{
    // TODO: Add your class here to draw all the actors in the game
    // making use of the OutputService object.
    class DrawActorsAction : Action
    {
        OutputService _outputService;
        public DrawActorsAction(OutputService outputService)
        {
            _outputService = outputService;
        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            // open one and then close it once
            _outputService.StartDrawing();
            // base.Execute(cast);
            foreach(List<Actor> artifact in cast.Values)
            {
                _outputService.DrawActors(artifact);
            }
            _outputService.EndDrawing();
        }
    }
}