class MyPiece < Piece
    def self.next_piece (board)
      MyPiece.new(All_My_Pieces.sample, board) # notice change
    end

All_My_Pieces = All_Pieces + [
     [[[0, 0], [-1, 0], [1, 0], [2, 0], [-2,0]],
     [[0, 0], [0, -1], [0, 1], [0, 2], [0, -2]]],
     rotations([[0, 0], [-1, 0], [1, 0], [0, -1], [-1,-1]]),
     rotations([[0, 0], [1, 0], [0, 1]])#
  ]

  def self.next_cheat_piece (board)
    MyPiece.new([[[0, 0]]], board)
  end
end

class MyBoard < Board
  attr_accessor :cheat

  def initialize (game)
    @cheat = false
    @grid = Array.new(num_rows) {Array.new(num_columns)}
    @current_block = MyPiece.next_piece(self)
    @score = 0
    @game = game
    @delay = 500
  end

  def rotate_180
    if !game_over? and @game.is_running?
      @current_block.move(0, 0, 2)
    end
    draw
  end

  def next_piece
    if (@cheat)
       @current_block = MyPiece.next_cheat_piece(self)
       @cheat = false
    else
       @current_block = MyPiece.next_piece(self)
    end
    @current_pos = nil
  end

  def maybe_cheat
    if @score >= 100 and !@cheat
      @score -= 100
      @cheat = true
    end
  end

end

class MyTetris < Tetris
  def key_bindings
    super
    super
    @root.bind('u', proc { @board.rotate_clockwise; @board.rotate_clockwise })
    @root.bind('c', proc { @board.maybe_cheat })
  end 

  def set_board
    @canvas = TetrisCanvas.new
    @board = MyBoard.new(self)
    @canvas.place(@board.block_size * @board.num_rows + 3, @board.block_size * @board.num_columns + 6, 24, 80)
    @board.draw
  end
end