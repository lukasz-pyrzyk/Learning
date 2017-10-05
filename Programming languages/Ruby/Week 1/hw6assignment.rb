# University of Washington, Programming Languages, Homework 6, hw6runner.rb

# This is the only file you turn in, so do not modify the other files as
# part of your solution.

class MyPiece < Piece
  # The constant All_My_Pieces should be declared here

  # your enhancements here

end

class MyBoard < Board
  # your enhancements here

end

class MyTetris < Tetris
  def initialize
    @root = TetrisRoot.new
    @timer = TetrisTimer.new
    set_board
    @running = true
    key_bindings
    buttons
    run_game
  end

  def set_board
    @canvas = TetrisCanvas.new
    @board = Board.new(self)
    @canvas.place(@board.block_size * @board.num_rows + 3,
                  @board.block_size * @board.num_columns + 6, 24, 80)
    @board.draw
  end

  def run_game
    if !@board.game_over? and @running
      @timer.stop
      @timer.start(@board.delay, (proc{@board.run; run_game}))
    end
  end

  def key_bindings
    @root.bind('u', proc {rotate})
  end

  def rotate
    @board.rotate_clockwise
    @board.rotate_clockwise
  end

end


